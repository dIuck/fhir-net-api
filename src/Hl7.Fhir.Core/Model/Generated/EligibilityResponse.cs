﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.3.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// EligibilityResponse resource
    /// </summary>
    [FhirType("EligibilityResponse", IsResource=true)]
    [DataContract]
    public partial class EligibilityResponse : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.EligibilityResponse; } }
        [NotMapped]
        public override string TypeName { get { return "EligibilityResponse"; } }
        
        [FhirType("BenefitsComponent")]
        [DataContract]
        public partial class BenefitsComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitsComponent"; } }
            
            /// <summary>
            /// Benefit Category
            /// </summary>
            [FhirElement("category", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.Coding _Category;
            
            /// <summary>
            /// Benefit SubCategory
            /// </summary>
            [FhirElement("subCategory", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Coding SubCategory
            {
                get { return _SubCategory; }
                set { _SubCategory = value; OnPropertyChanged("SubCategory"); }
            }
            
            private Hl7.Fhir.Model.Coding _SubCategory;
            
            /// <summary>
            /// In or out of network
            /// </summary>
            [FhirElement("network", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Network
            {
                get { return _Network; }
                set { _Network = value; OnPropertyChanged("Network"); }
            }
            
            private Hl7.Fhir.Model.Coding _Network;
            
            /// <summary>
            /// Individual or family
            /// </summary>
            [FhirElement("unit", InSummary=true, Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Unit
            {
                get { return _Unit; }
                set { _Unit = value; OnPropertyChanged("Unit"); }
            }
            
            private Hl7.Fhir.Model.Coding _Unit;
            
            /// <summary>
            /// Annual or lifetime
            /// </summary>
            [FhirElement("term", InSummary=true, Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Term
            {
                get { return _Term; }
                set { _Term = value; OnPropertyChanged("Term"); }
            }
            
            private Hl7.Fhir.Model.Coding _Term;
            
            /// <summary>
            /// Benefit Summary
            /// </summary>
            [FhirElement("financial", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.EligibilityResponse.BenefitComponent> Financial
            {
                get { if(_Financial==null) _Financial = new List<Hl7.Fhir.Model.EligibilityResponse.BenefitComponent>(); return _Financial; }
                set { _Financial = value; OnPropertyChanged("Financial"); }
            }
            
            private List<Hl7.Fhir.Model.EligibilityResponse.BenefitComponent> _Financial;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitsComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.Coding)Category.DeepCopy();
                    if(SubCategory != null) dest.SubCategory = (Hl7.Fhir.Model.Coding)SubCategory.DeepCopy();
                    if(Network != null) dest.Network = (Hl7.Fhir.Model.Coding)Network.DeepCopy();
                    if(Unit != null) dest.Unit = (Hl7.Fhir.Model.Coding)Unit.DeepCopy();
                    if(Term != null) dest.Term = (Hl7.Fhir.Model.Coding)Term.DeepCopy();
                    if(Financial != null) dest.Financial = new List<Hl7.Fhir.Model.EligibilityResponse.BenefitComponent>(Financial.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new BenefitsComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BenefitsComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(SubCategory, otherT.SubCategory)) return false;
                if( !DeepComparable.Matches(Network, otherT.Network)) return false;
                if( !DeepComparable.Matches(Unit, otherT.Unit)) return false;
                if( !DeepComparable.Matches(Term, otherT.Term)) return false;
                if( !DeepComparable.Matches(Financial, otherT.Financial)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitsComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(SubCategory, otherT.SubCategory)) return false;
                if( !DeepComparable.IsExactly(Network, otherT.Network)) return false;
                if( !DeepComparable.IsExactly(Unit, otherT.Unit)) return false;
                if( !DeepComparable.IsExactly(Term, otherT.Term)) return false;
                if( !DeepComparable.IsExactly(Financial, otherT.Financial)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("BenefitComponent")]
        [DataContract]
        public partial class BenefitComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitComponent"; } }
            
            /// <summary>
            /// Deductable, visits, benefit amount
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.Coding _Type;
            
            /// <summary>
            /// Benefits allowed
            /// </summary>
            [FhirElement("benefit", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.UnsignedInt),typeof(Hl7.Fhir.Model.Money))]
            [DataMember]
            public Hl7.Fhir.Model.Element Benefit
            {
                get { return _Benefit; }
                set { _Benefit = value; OnPropertyChanged("Benefit"); }
            }
            
            private Hl7.Fhir.Model.Element _Benefit;
            
            /// <summary>
            /// Benefits used
            /// </summary>
            [FhirElement("benefitUsed", InSummary=true, Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.UnsignedInt),typeof(Hl7.Fhir.Model.Money))]
            [DataMember]
            public Hl7.Fhir.Model.Element BenefitUsed
            {
                get { return _BenefitUsed; }
                set { _BenefitUsed = value; OnPropertyChanged("BenefitUsed"); }
            }
            
            private Hl7.Fhir.Model.Element _BenefitUsed;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.Coding)Type.DeepCopy();
                    if(Benefit != null) dest.Benefit = (Hl7.Fhir.Model.Element)Benefit.DeepCopy();
                    if(BenefitUsed != null) dest.BenefitUsed = (Hl7.Fhir.Model.Element)BenefitUsed.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new BenefitComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BenefitComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Benefit, otherT.Benefit)) return false;
                if( !DeepComparable.Matches(BenefitUsed, otherT.BenefitUsed)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Benefit, otherT.Benefit)) return false;
                if( !DeepComparable.IsExactly(BenefitUsed, otherT.BenefitUsed)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("ErrorsComponent")]
        [DataContract]
        public partial class ErrorsComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ErrorsComponent"; } }
            
            /// <summary>
            /// Error code detailing processing issues
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.Coding _Code;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ErrorsComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.Coding)Code.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ErrorsComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ErrorsComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ErrorsComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// Business Identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Claim reference
        /// </summary>
        [FhirElement("request", InSummary=true, Order=100, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.Identifier),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Request
        {
            get { return _Request; }
            set { _Request = value; OnPropertyChanged("Request"); }
        }
        
        private Hl7.Fhir.Model.Element _Request;
        
        /// <summary>
        /// complete | error
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=110)]
        [DataMember]
        public Code<Hl7.Fhir.Model.RemittanceOutcome> OutcomeElement
        {
            get { return _OutcomeElement; }
            set { _OutcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.RemittanceOutcome> _OutcomeElement;
        
        /// <summary>
        /// complete | error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.RemittanceOutcome? Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if(value == null)
                  OutcomeElement = null; 
                else
                  OutcomeElement = new Code<Hl7.Fhir.Model.RemittanceOutcome>(value);
                OnPropertyChanged("Outcome");
            }
        }
        
        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", InSummary=true, Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DispositionElement
        {
            get { return _DispositionElement; }
            set { _DispositionElement = value; OnPropertyChanged("DispositionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DispositionElement;
        
        /// <summary>
        /// Disposition Message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Disposition
        {
            get { return DispositionElement != null ? DispositionElement.Value : null; }
            set
            {
                if(value == null)
                  DispositionElement = null; 
                else
                  DispositionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Disposition");
            }
        }
        
        /// <summary>
        /// Resource version
        /// </summary>
        [FhirElement("ruleset", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.Coding Ruleset
        {
            get { return _Ruleset; }
            set { _Ruleset = value; OnPropertyChanged("Ruleset"); }
        }
        
        private Hl7.Fhir.Model.Coding _Ruleset;
        
        /// <summary>
        /// Original version
        /// </summary>
        [FhirElement("originalRuleset", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.Coding OriginalRuleset
        {
            get { return _OriginalRuleset; }
            set { _OriginalRuleset = value; OnPropertyChanged("OriginalRuleset"); }
        }
        
        private Hl7.Fhir.Model.Coding _OriginalRuleset;
        
        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", InSummary=true, Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime CreatedElement
        {
            get { return _CreatedElement; }
            set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _CreatedElement;
        
        /// <summary>
        /// Creation date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if(value == null)
                  CreatedElement = null; 
                else
                  CreatedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }
        
        /// <summary>
        /// Insurer
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.Identifier),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Organization
        {
            get { return _Organization; }
            set { _Organization = value; OnPropertyChanged("Organization"); }
        }
        
        private Hl7.Fhir.Model.Element _Organization;
        
        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("requestProvider", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.Identifier),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element RequestProvider
        {
            get { return _RequestProvider; }
            set { _RequestProvider = value; OnPropertyChanged("RequestProvider"); }
        }
        
        private Hl7.Fhir.Model.Element _RequestProvider;
        
        /// <summary>
        /// Responsible organization
        /// </summary>
        [FhirElement("requestOrganization", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.Identifier),typeof(Hl7.Fhir.Model.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element RequestOrganization
        {
            get { return _RequestOrganization; }
            set { _RequestOrganization = value; OnPropertyChanged("RequestOrganization"); }
        }
        
        private Hl7.Fhir.Model.Element _RequestOrganization;
        
        /// <summary>
        /// Coverage inforce
        /// </summary>
        [FhirElement("inforce", InSummary=true, Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean InforceElement
        {
            get { return _InforceElement; }
            set { _InforceElement = value; OnPropertyChanged("InforceElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _InforceElement;
        
        /// <summary>
        /// Coverage inforce
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Inforce
        {
            get { return InforceElement != null ? InforceElement.Value : null; }
            set
            {
                if(value == null)
                  InforceElement = null; 
                else
                  InforceElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Inforce");
            }
        }
        
        /// <summary>
        /// Contract details
        /// </summary>
        [FhirElement("contract", InSummary=true, Order=200)]
        [References("Contract")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Contract
        {
            get { return _Contract; }
            set { _Contract = value; OnPropertyChanged("Contract"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Contract;
        
        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", InSummary=true, Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.Coding Form
        {
            get { return _Form; }
            set { _Form = value; OnPropertyChanged("Form"); }
        }
        
        private Hl7.Fhir.Model.Coding _Form;
        
        /// <summary>
        /// Benefits by Category
        /// </summary>
        [FhirElement("benefitBalance", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.EligibilityResponse.BenefitsComponent> BenefitBalance
        {
            get { if(_BenefitBalance==null) _BenefitBalance = new List<Hl7.Fhir.Model.EligibilityResponse.BenefitsComponent>(); return _BenefitBalance; }
            set { _BenefitBalance = value; OnPropertyChanged("BenefitBalance"); }
        }
        
        private List<Hl7.Fhir.Model.EligibilityResponse.BenefitsComponent> _BenefitBalance;
        
        /// <summary>
        /// Processing errors
        /// </summary>
        [FhirElement("error", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.EligibilityResponse.ErrorsComponent> Error
        {
            get { if(_Error==null) _Error = new List<Hl7.Fhir.Model.EligibilityResponse.ErrorsComponent>(); return _Error; }
            set { _Error = value; OnPropertyChanged("Error"); }
        }
        
        private List<Hl7.Fhir.Model.EligibilityResponse.ErrorsComponent> _Error;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as EligibilityResponse;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(Request != null) dest.Request = (Hl7.Fhir.Model.Element)Request.DeepCopy();
                if(OutcomeElement != null) dest.OutcomeElement = (Code<Hl7.Fhir.Model.RemittanceOutcome>)OutcomeElement.DeepCopy();
                if(DispositionElement != null) dest.DispositionElement = (Hl7.Fhir.Model.FhirString)DispositionElement.DeepCopy();
                if(Ruleset != null) dest.Ruleset = (Hl7.Fhir.Model.Coding)Ruleset.DeepCopy();
                if(OriginalRuleset != null) dest.OriginalRuleset = (Hl7.Fhir.Model.Coding)OriginalRuleset.DeepCopy();
                if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.FhirDateTime)CreatedElement.DeepCopy();
                if(Organization != null) dest.Organization = (Hl7.Fhir.Model.Element)Organization.DeepCopy();
                if(RequestProvider != null) dest.RequestProvider = (Hl7.Fhir.Model.Element)RequestProvider.DeepCopy();
                if(RequestOrganization != null) dest.RequestOrganization = (Hl7.Fhir.Model.Element)RequestOrganization.DeepCopy();
                if(InforceElement != null) dest.InforceElement = (Hl7.Fhir.Model.FhirBoolean)InforceElement.DeepCopy();
                if(Contract != null) dest.Contract = (Hl7.Fhir.Model.ResourceReference)Contract.DeepCopy();
                if(Form != null) dest.Form = (Hl7.Fhir.Model.Coding)Form.DeepCopy();
                if(BenefitBalance != null) dest.BenefitBalance = new List<Hl7.Fhir.Model.EligibilityResponse.BenefitsComponent>(BenefitBalance.DeepCopy());
                if(Error != null) dest.Error = new List<Hl7.Fhir.Model.EligibilityResponse.ErrorsComponent>(Error.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new EligibilityResponse());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as EligibilityResponse;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Request, otherT.Request)) return false;
            if( !DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if( !DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
            if( !DeepComparable.Matches(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if( !DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if( !DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
            if( !DeepComparable.Matches(InforceElement, otherT.InforceElement)) return false;
            if( !DeepComparable.Matches(Contract, otherT.Contract)) return false;
            if( !DeepComparable.Matches(Form, otherT.Form)) return false;
            if( !DeepComparable.Matches(BenefitBalance, otherT.BenefitBalance)) return false;
            if( !DeepComparable.Matches(Error, otherT.Error)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as EligibilityResponse;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if( !DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if( !DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
            if( !DeepComparable.IsExactly(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if( !DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if( !DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
            if( !DeepComparable.IsExactly(InforceElement, otherT.InforceElement)) return false;
            if( !DeepComparable.IsExactly(Contract, otherT.Contract)) return false;
            if( !DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if( !DeepComparable.IsExactly(BenefitBalance, otherT.BenefitBalance)) return false;
            if( !DeepComparable.IsExactly(Error, otherT.Error)) return false;
            
            return true;
        }
        
    }
    
}
