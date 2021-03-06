﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:2.0.50727.5466
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.aquasoft.eu/iska", ConfigurationName="AuthorizationServiceSoap")]
public interface AuthorizationServiceSoap
{
    
    // CODEGEN: Probíhá generování kontraktu zprávy, protože ve zprávě GetAuthorizationsRequest se nacházejí záhlaví
    [System.ServiceModel.OperationContractAttribute(Action="http://www.aquasoft.eu/iska/GetAuthorizations", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GetAuthorizationsResponse GetAuthorizations(GetAuthorizationsRequest request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class Access
{
    
    private string userField;
    
    private string passwordField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string User
    {
        get
        {
            return this.userField;
        }
        set
        {
            this.userField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr
    {
        get
        {
            return this.anyAttrField;
        }
        set
        {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class RepresentativePerson
{
    
    private string frontDegreeField;
    
    private string backDegreeField;
    
    private string firstNameField;
    
    private string lastNameField;
    
    private System.Guid representativePersonIdField;
    
    private System.Guid representativePersonVersionIdField;
    
    private System.Guid authorizedPersonIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string FrontDegree
    {
        get
        {
            return this.frontDegreeField;
        }
        set
        {
            this.frontDegreeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BackDegree
    {
        get
        {
            return this.backDegreeField;
        }
        set
        {
            this.backDegreeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public System.Guid RepresentativePersonId
    {
        get
        {
            return this.representativePersonIdField;
        }
        set
        {
            this.representativePersonIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public System.Guid RepresentativePersonVersionId
    {
        get
        {
            return this.representativePersonVersionIdField;
        }
        set
        {
            this.representativePersonVersionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public System.Guid AuthorizedPersonId
    {
        get
        {
            return this.authorizedPersonIdField;
        }
        set
        {
            this.authorizedPersonIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class AuthPersonContact
{
    
    private System.Guid idField;
    
    private ContactKind contactTypeField;
    
    private string contactValueField;
    
    private string contactNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public System.Guid Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ContactKind ContactType
    {
        get
        {
            return this.contactTypeField;
        }
        set
        {
            this.contactTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string ContactValue
    {
        get
        {
            return this.contactValueField;
        }
        set
        {
            this.contactValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string ContactName
    {
        get
        {
            return this.contactNameField;
        }
        set
        {
            this.contactNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public enum ContactKind
{
    
    /// <remarks/>
    Phone,
    
    /// <remarks/>
    Mobile,
    
    /// <remarks/>
    Email,
    
    /// <remarks/>
    Fax,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class AuthPersonQualification
{
    
    private int qualificationIdField;
    
    private System.Guid authorizedPersonIdField;
    
    private System.DateTime validFromField;
    
    private System.DateTime validToField;
    
    private AuthPersonContact[] contactsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int QualificationId
    {
        get
        {
            return this.qualificationIdField;
        }
        set
        {
            this.qualificationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.Guid AuthorizedPersonId
    {
        get
        {
            return this.authorizedPersonIdField;
        }
        set
        {
            this.authorizedPersonIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime ValidFrom
    {
        get
        {
            return this.validFromField;
        }
        set
        {
            this.validFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime ValidTo
    {
        get
        {
            return this.validToField;
        }
        set
        {
            this.validToField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    public AuthPersonContact[] Contacts
    {
        get
        {
            return this.contactsField;
        }
        set
        {
            this.contactsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class AuthPersonAddress
{
    
    private System.Guid idField;
    
    private AuthPersonAddressType addressTypeField;
    
    private string streetField;
    
    private string cityField;
    
    private string zipField;
    
    private string numberField;
    
    private string orientationNumberField;
    
    private string countryField;
    
    private string districtField;
    
    private string regionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public System.Guid Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public AuthPersonAddressType AddressType
    {
        get
        {
            return this.addressTypeField;
        }
        set
        {
            this.addressTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string Zip
    {
        get
        {
            return this.zipField;
        }
        set
        {
            this.zipField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string OrientationNumber
    {
        get
        {
            return this.orientationNumberField;
        }
        set
        {
            this.orientationNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public string District
    {
        get
        {
            return this.districtField;
        }
        set
        {
            this.districtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string Region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public enum AuthPersonAddressType
{
    
    /// <remarks/>
    Residence,
    
    /// <remarks/>
    Contact,
    
    /// <remarks/>
    Delivery,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class AuthPerson
{
    
    private string frontDegreeField;
    
    private string backDegreeField;
    
    private string firstNameField;
    
    private string lastNameField;
    
    private string organizationNameField;
    
    private string legalFormField;
    
    private string iCOField;
    
    private AuthorizedPersonType authorizedPersonTypeField;
    
    private System.Guid authorizedPersonIdField;
    
    private System.Guid authorizedPersonVersionIdField;
    
    private IszrVerificationStatus iszrVerificationStatusField;
    
    private AuthPersonAddress[] addressesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string FrontDegree
    {
        get
        {
            return this.frontDegreeField;
        }
        set
        {
            this.frontDegreeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string BackDegree
    {
        get
        {
            return this.backDegreeField;
        }
        set
        {
            this.backDegreeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string OrganizationName
    {
        get
        {
            return this.organizationNameField;
        }
        set
        {
            this.organizationNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public string LegalForm
    {
        get
        {
            return this.legalFormField;
        }
        set
        {
            this.legalFormField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public string ICO
    {
        get
        {
            return this.iCOField;
        }
        set
        {
            this.iCOField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public AuthorizedPersonType AuthorizedPersonType
    {
        get
        {
            return this.authorizedPersonTypeField;
        }
        set
        {
            this.authorizedPersonTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public System.Guid AuthorizedPersonId
    {
        get
        {
            return this.authorizedPersonIdField;
        }
        set
        {
            this.authorizedPersonIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public System.Guid AuthorizedPersonVersionId
    {
        get
        {
            return this.authorizedPersonVersionIdField;
        }
        set
        {
            this.authorizedPersonVersionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public IszrVerificationStatus IszrVerificationStatus
    {
        get
        {
            return this.iszrVerificationStatusField;
        }
        set
        {
            this.iszrVerificationStatusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=11)]
    public AuthPersonAddress[] Addresses
    {
        get
        {
            return this.addressesField;
        }
        set
        {
            this.addressesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public enum AuthorizedPersonType
{
    
    /// <remarks/>
    FO,
    
    /// <remarks/>
    FOP,
    
    /// <remarks/>
    PO,
    
    /// <remarks/>
    School,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public enum IszrVerificationStatus
{
    
    /// <remarks/>
    NotVerified,
    
    /// <remarks/>
    Correct,
    
    /// <remarks/>
    Incorrect,
    
    /// <remarks/>
    Unknown,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class RepresentativePersonQualification
{
    
    private int qualificationIdField;
    
    private System.Guid representativePersonIdField;
    
    private System.DateTime validFromField;
    
    private System.DateTime validToField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int QualificationId
    {
        get
        {
            return this.qualificationIdField;
        }
        set
        {
            this.qualificationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.Guid RepresentativePersonId
    {
        get
        {
            return this.representativePersonIdField;
        }
        set
        {
            this.representativePersonIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime ValidFrom
    {
        get
        {
            return this.validFromField;
        }
        set
        {
            this.validFromField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public System.DateTime ValidTo
    {
        get
        {
            return this.validToField;
        }
        set
        {
            this.validToField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.aquasoft.eu/iska")]
public partial class AuthorizedPersonData
{
    
    private RepresentativePersonQualification[] representativePersonQualificationsField;
    
    private AuthPerson[] authorizedPersonsField;
    
    private AuthPersonQualification[] authorizedPersonQualificationsField;
    
    private RepresentativePerson[] represenatativePersonsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    public RepresentativePersonQualification[] RepresentativePersonQualifications
    {
        get
        {
            return this.representativePersonQualificationsField;
        }
        set
        {
            this.representativePersonQualificationsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    public AuthPerson[] AuthorizedPersons
    {
        get
        {
            return this.authorizedPersonsField;
        }
        set
        {
            this.authorizedPersonsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    public AuthPersonQualification[] AuthorizedPersonQualifications
    {
        get
        {
            return this.authorizedPersonQualificationsField;
        }
        set
        {
            this.authorizedPersonQualificationsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    public RepresentativePerson[] RepresenatativePersons
    {
        get
        {
            return this.represenatativePersonsField;
        }
        set
        {
            this.represenatativePersonsField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetAuthorizations", WrapperNamespace="http://www.aquasoft.eu/iska", IsWrapped=true)]
public partial class GetAuthorizationsRequest
{
    
    [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.aquasoft.eu/iska")]
    public Access Access;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.aquasoft.eu/iska", Order=0)]
    public System.DateTime fromDate;
    
    public GetAuthorizationsRequest()
    {
    }
    
    public GetAuthorizationsRequest(Access Access, System.DateTime fromDate)
    {
        this.Access = Access;
        this.fromDate = fromDate;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetAuthorizationsResponse", WrapperNamespace="http://www.aquasoft.eu/iska", IsWrapped=true)]
public partial class GetAuthorizationsResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.aquasoft.eu/iska", Order=0)]
    public AuthorizedPersonData GetAuthorizationsResult;
    
    public GetAuthorizationsResponse()
    {
    }
    
    public GetAuthorizationsResponse(AuthorizedPersonData GetAuthorizationsResult)
    {
        this.GetAuthorizationsResult = GetAuthorizationsResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface AuthorizationServiceSoapChannel : AuthorizationServiceSoap, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class AuthorizationServiceSoapClient : System.ServiceModel.ClientBase<AuthorizationServiceSoap>, AuthorizationServiceSoap
{
    
    public AuthorizationServiceSoapClient()
    {
    }
    
    public AuthorizationServiceSoapClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public AuthorizationServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AuthorizationServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AuthorizationServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetAuthorizationsResponse AuthorizationServiceSoap.GetAuthorizations(GetAuthorizationsRequest request)
    {
        return base.Channel.GetAuthorizations(request);
    }
    
    public AuthorizedPersonData GetAuthorizations(Access Access, System.DateTime fromDate)
    {
        GetAuthorizationsRequest inValue = new GetAuthorizationsRequest();
        inValue.Access = Access;
        inValue.fromDate = fromDate;
        GetAuthorizationsResponse retVal = ((AuthorizationServiceSoap)(this)).GetAuthorizations(inValue);
        return retVal.GetAuthorizationsResult;
    }
}
