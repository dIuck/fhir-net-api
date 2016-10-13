﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Specification.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Hl7.Fhir.Validation
{
    public class ResolverFixture
    {
        public IResourceResolver Resolver { get; }

        public ResolverFixture()
        {
            Resolver = new CachedResolver(
                new MultiResolver(
                    new TestProfileArtifactSource(),
                    new ZipSource("specification.zip")));
        }
    }

    public class ProfileAssertionTests : IClassFixture<ResolverFixture>
    {
        private IResourceResolver _resolver;

        public ProfileAssertionTests(ResolverFixture fixture)
        {
            _resolver = fixture.Resolver;
        }

        [Fact]
        public void InitializationAndResolution()
        {
            var sd = _resolver.FindStructureDefinitionForCoreType(FHIRDefinedType.ValueSet);

            var assertion = new ProfileAssertion(ModelInfo.CanonicalUriForFhirCoreType(FHIRDefinedType.ValueSet),
                                                    ModelInfo.CanonicalUriForFhirCoreType(FHIRDefinedType.ValueSet), "Patient.name[0]");
            assertion.AddStatedProfile("http://hl7.org/fhir/StructureDefinition/shareablevalueset");

            Assert.Equal(2, assertion.AllProfiles.Count());
            Assert.Equal(2, assertion.AllProfiles.Count(p => p.Status == null));    // status == null is only true for unresolved resources

            assertion.AddStatedProfile(sd);

            Assert.Equal(2, assertion.AllProfiles.Count());         // Adding a ValueSet SD that was already there does not increase the profile count
            Assert.Equal(1, assertion.AllProfiles.Count(p => p.Status == null));    // but now there's 1 unresolved profile less
            Assert.True(assertion.AllProfiles.Contains(sd)); // the other being the Sd we just added

            Assert.Equal(sd, assertion.InstanceType);
            Assert.Equal(sd, assertion.DeclaredType);

            var outcome = assertion.Resolve(resolve);
            Assert.True(outcome.Success);
            Assert.Equal(2, assertion.AllProfiles.Count());         // We should still have 2 distinct SDs
            Assert.Equal(0, assertion.AllProfiles.Count(p => p.Status == null));    // none remain unresolved
            Assert.True(assertion.AllProfiles.Contains(sd)); // one still being the Sd we manually added

            assertion.AddStatedProfile("http://hl7.org/fhir/StructureDefinition/unresolvable");

            outcome = assertion.Resolve(resolve);
            Assert.False(outcome.Success);
            Assert.Equal(3, assertion.AllProfiles.Count());         // We should still have 3 distinct SDs
            Assert.Equal(1, assertion.AllProfiles.Count(p => p.Status == null));    // one remains unresolved
            Assert.True(assertion.AllProfiles.Contains(sd)); // one still being the Sd we manually added        
        }


        private StructureDefinition resolve(string uri) => _resolver.FindStructureDefinition(uri);

        [Fact]
        public void NormalElement()
        {
            var assertion = new ProfileAssertion(null, ModelInfo.CanonicalUriForFhirCoreType(FHIRDefinedType.HumanName), "Patient.name[0]");
            Assert.True(assertion.Validate(resolve).Success);

            assertion.SetInstanceType(FHIRDefinedType.HumanName);
            Assert.True(assertion.Validate(resolve).Success);

            Assert.Single(assertion.MinimalProfiles, assertion.DeclaredType);

            assertion.SetInstanceType(FHIRDefinedType.Identifier);
            var report = assertion.Validate(resolve);
            Assert.False(report.Success);
            Assert.Contains("is incompatible with that of the instance", report.ToString());
        }

        [Fact]
        public void QuantityElement()
        {
            var assertion = new ProfileAssertion(null, ModelInfo.CanonicalUriForFhirCoreType(FHIRDefinedType.Age), "Patient.name[0]");

            assertion.SetInstanceType(FHIRDefinedType.Quantity);
            Assert.True(assertion.Validate(resolve).Success);
            Assert.Single(assertion.MinimalProfiles, assertion.DeclaredType);

            assertion.SetInstanceType(FHIRDefinedType.Identifier);
            var report = assertion.Validate(resolve);
            Assert.False(report.Success);
            Assert.Contains("is incompatible with that of the instance", report.ToString());
        }

        [Fact]
        public void ProfiledElement()
        {
            var assertion = new ProfileAssertion(null, "http://validationtest.org/fhir/StructureDefinition/IdentifierWithBSN", "Patient.identifier[0]");
            Assert.True(assertion.Validate(resolve).Success);

            assertion.SetInstanceType(FHIRDefinedType.Identifier);
            Assert.True(assertion.Validate(resolve).Success);
            Assert.Single(assertion.MinimalProfiles, assertion.DeclaredType);

            assertion.SetInstanceType(FHIRDefinedType.HumanName);
            var report = assertion.Validate(resolve);
            Assert.False(report.Success);
            Assert.Contains("is incompatible with that of the instance", report.ToString());
        }

        [Fact]
        public void ContainedResource()
        {
            var assertion = new ProfileAssertion(null,
                ModelInfo.CanonicalUriForFhirCoreType(FHIRDefinedType.Resource), "Bundle.entry.resource[0]");
            Assert.True(assertion.Validate(resolve).Success);

            assertion.SetInstanceType(FHIRDefinedType.Patient);
            Assert.True(assertion.Validate(resolve).Success);

            assertion.SetDeclaredType(FHIRDefinedType.DomainResource);
            Assert.True(assertion.Validate(resolve).Success);

            Assert.Single(assertion.MinimalProfiles, assertion.InstanceType);

            assertion.SetInstanceType(FHIRDefinedType.Binary);
            var report = assertion.Validate(resolve);
            Assert.False(report.Success);
            Assert.Contains("is incompatible with that of the instance", report.ToString());
        }

        
        [Fact]
        public void ResourceWithStatedProfiles()
        {
            var assertion = new ProfileAssertion(null,
                ModelInfo.CanonicalUriForFhirCoreType(FHIRDefinedType.Observation), "Observation");
            Assert.True(assertion.Validate(resolve).Success);

            assertion.AddStatedProfile(ModelInfo.CanonicalUriForFhirCoreType(FHIRDefinedType.Observation));
            assertion.AddStatedProfile("http://validationtest.org/fhir/StructureDefinition/WeightHeightObservation");
            assertion.AddStatedProfile("http://hl7.org/fhir/StructureDefinition/devicemetricobservation");
            
            var report = assertion.Validate(resolve);
            Assert.True(report.Success);
            Assert.Equal(2, assertion.MinimalProfiles.Count());
            Assert.Equal( assertion.MinimalProfiles, assertion.StatedProfiles.Skip(1));

            assertion.SetDeclaredType(FHIRDefinedType.Procedure);
            report = assertion.Validate(resolve);

            Assert.False(report.Success);
            Assert.Contains("is incompatible with the declared type", report.ToString());
        }

    }

}
