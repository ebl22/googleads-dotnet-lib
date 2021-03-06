// Copyright 2014, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Author: api.anash@gmail.com (Anash P. Oommen)

#pragma warning disable 1591

namespace Google.Api.Ads.AdWords.v201409 {
  using Google.Api.Ads.AdWords.Headers;
  using Google.Api.Ads.AdWords.Lib;

  using System.Web.Services.Protocols;
  using System;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Web.Services;
  using System.Xml.Serialization;

  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignAdExtensionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignAdExtensionService : AdWordsSoapClient, ICampaignAdExtensionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignAdExtensionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/CampaignAdExtensionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignAdExtensionPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((CampaignAdExtensionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignAdExtensionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignAdExtensionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((CampaignAdExtensionReturnValue) (results[0]));
    }
  }

















  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionReturnValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignLabelReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignFeedReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerFeedReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdLabelReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedItemReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedMappingReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfflineConversionFeedReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupFeedReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignSharedSetReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedCriterionReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLabelReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedSetReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupLabelReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidModifierReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingStrategyReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOrderReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetReturnValue))]
  public abstract partial class ListReturnValue {
    private string listReturnValueTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ListReturnValue.Type")]
    public string ListReturnValueType {
      get { return this.listReturnValueTypeField; }
      set { this.listReturnValueTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignAdExtensionReturnValue : ListReturnValue {
    private CampaignAdExtension[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignAdExtension[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignAdExtension {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private AdExtension adExtensionField;

    private CampaignAdExtensionStatus statusField;

    private bool statusFieldSpecified;

    private CampaignAdExtensionApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public AdExtension adExtension {
      get { return this.adExtensionField; }
      set { this.adExtensionField = value; }
    }

    public CampaignAdExtensionStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public CampaignAdExtensionApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationSyncExtension))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationExtension))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdExtension {
    private long idField;

    private bool idFieldSpecified;

    private string adExtensionTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdExtension.Type")]
    public string AdExtensionType {
      get { return this.adExtensionTypeField; }
      set { this.adExtensionTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LocationSyncExtension : AdExtension {
    private string emailField;

    private OAuthInfo oAuthInfoField;

    private long iconMediaIdField;

    private bool iconMediaIdFieldSpecified;

    private bool shouldSyncUrlField;

    private bool shouldSyncUrlFieldSpecified;

    public string email {
      get { return this.emailField; }
      set { this.emailField = value; }
    }

    public OAuthInfo oAuthInfo {
      get { return this.oAuthInfoField; }
      set { this.oAuthInfoField = value; }
    }

    public long iconMediaId {
      get { return this.iconMediaIdField; }
      set {
        this.iconMediaIdField = value;
        this.iconMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool iconMediaIdSpecified {
      get { return this.iconMediaIdFieldSpecified; }
      set { this.iconMediaIdFieldSpecified = value; }
    }

    public bool shouldSyncUrl {
      get { return this.shouldSyncUrlField; }
      set {
        this.shouldSyncUrlField = value;
        this.shouldSyncUrlSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool shouldSyncUrlSpecified {
      get { return this.shouldSyncUrlFieldSpecified; }
      set { this.shouldSyncUrlFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OAuthInfo {
    private string httpMethodField;

    private string httpRequestUrlField;

    private string httpAuthorizationHeaderField;

    public string httpMethod {
      get { return this.httpMethodField; }
      set { this.httpMethodField = value; }
    }

    public string httpRequestUrl {
      get { return this.httpRequestUrlField; }
      set { this.httpRequestUrlField = value; }
    }

    public string httpAuthorizationHeader {
      get { return this.httpAuthorizationHeaderField; }
      set { this.httpAuthorizationHeaderField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LocationExtension : AdExtension {
    private Address addressField;

    private GeoPoint geoPointField;

    private byte[] encodedLocationField;

    private string companyNameField;

    private string phoneNumberField;

    private LocationExtensionSource sourceField;

    private bool sourceFieldSpecified;

    private long iconMediaIdField;

    private bool iconMediaIdFieldSpecified;

    private long imageMediaIdField;

    private bool imageMediaIdFieldSpecified;

    public Address address {
      get { return this.addressField; }
      set { this.addressField = value; }
    }

    public GeoPoint geoPoint {
      get { return this.geoPointField; }
      set { this.geoPointField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] encodedLocation {
      get { return this.encodedLocationField; }
      set { this.encodedLocationField = value; }
    }

    public string companyName {
      get { return this.companyNameField; }
      set { this.companyNameField = value; }
    }

    public string phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }

    public LocationExtensionSource source {
      get { return this.sourceField; }
      set {
        this.sourceField = value;
        this.sourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sourceSpecified {
      get { return this.sourceFieldSpecified; }
      set { this.sourceFieldSpecified = value; }
    }

    public long iconMediaId {
      get { return this.iconMediaIdField; }
      set {
        this.iconMediaIdField = value;
        this.iconMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool iconMediaIdSpecified {
      get { return this.iconMediaIdFieldSpecified; }
      set { this.iconMediaIdFieldSpecified = value; }
    }

    public long imageMediaId {
      get { return this.imageMediaIdField; }
      set {
        this.imageMediaIdField = value;
        this.imageMediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool imageMediaIdSpecified {
      get { return this.imageMediaIdFieldSpecified; }
      set { this.imageMediaIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Address {
    private string streetAddressField;

    private string streetAddress2Field;

    private string cityNameField;

    private string provinceCodeField;

    private string provinceNameField;

    private string postalCodeField;

    private string countryCodeField;

    public string streetAddress {
      get { return this.streetAddressField; }
      set { this.streetAddressField = value; }
    }

    public string streetAddress2 {
      get { return this.streetAddress2Field; }
      set { this.streetAddress2Field = value; }
    }

    public string cityName {
      get { return this.cityNameField; }
      set { this.cityNameField = value; }
    }

    public string provinceCode {
      get { return this.provinceCodeField; }
      set { this.provinceCodeField = value; }
    }

    public string provinceName {
      get { return this.provinceNameField; }
      set { this.provinceNameField = value; }
    }

    public string postalCode {
      get { return this.postalCodeField; }
      set { this.postalCodeField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class GeoPoint {
    private int latitudeInMicroDegreesField;

    private bool latitudeInMicroDegreesFieldSpecified;

    private int longitudeInMicroDegreesField;

    private bool longitudeInMicroDegreesFieldSpecified;

    public int latitudeInMicroDegrees {
      get { return this.latitudeInMicroDegreesField; }
      set {
        this.latitudeInMicroDegreesField = value;
        this.latitudeInMicroDegreesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool latitudeInMicroDegreesSpecified {
      get { return this.latitudeInMicroDegreesFieldSpecified; }
      set { this.latitudeInMicroDegreesFieldSpecified = value; }
    }

    public int longitudeInMicroDegrees {
      get { return this.longitudeInMicroDegreesField; }
      set {
        this.longitudeInMicroDegreesField = value;
        this.longitudeInMicroDegreesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool longitudeInMicroDegreesSpecified {
      get { return this.longitudeInMicroDegreesFieldSpecified; }
      set { this.longitudeInMicroDegreesFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationExtension.Source", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum LocationExtensionSource {
    ADWORDS_FRONTEND,
    LBC_SYNC
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtension.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignAdExtensionStatus {
    ENABLED,
    REMOVED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtension.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignAdExtensionApprovalStatus {
    APPROVED,
    UNCHECKED,
    DISAPPROVED
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DatabaseError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringLengthError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SizeLimitError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SelectorError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequiredError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RejectedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegionCodeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReadOnlyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RateExceededError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RangeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotaCheckError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PagingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatorError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperationAccessDenied))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NullError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotEmptyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NewEntityCreationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InternalApiError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNotFound))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityCountLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistinctError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClientTermsError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuthorizationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AuthenticationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdxError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdExtensionError))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UrlError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringFormatError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsQueryError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SettingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(QuotaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForwardCompatibilityError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAccessDenied))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateRangeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingErrors))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CollectionSizeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignFeedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerSyncError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerFeedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolicyViolationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MediaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionParsingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdCountLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedItemError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedMappingError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoLocationError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationCriterionServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManagedCustomerServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(VideoError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AudioError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionPolicyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultiplierError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(JobError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupServiceError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfflineConversionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurrencyCodeError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupFeedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReportDefinitionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotWhitelistedError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrafficEstimatorError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetingIdeaError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpressBusinessError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PromotionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignSharedSetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedCriterionError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedSetError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamPolicyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingStrategyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerOrderLineError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOrderError))]
  public abstract partial class ApiError {
    private string fieldPathField;

    private string triggerField;

    private string errorStringField;

    private string apiErrorTypeField;

    public string fieldPath {
      get { return this.fieldPathField; }
      set { this.fieldPathField = value; }
    }

    public string trigger {
      get { return this.triggerField; }
      set { this.triggerField = value; }
    }

    public string errorString {
      get { return this.errorStringField; }
      set { this.errorStringField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ApiError.Type")]
    public string ApiErrorType {
      get { return this.apiErrorTypeField; }
      set { this.apiErrorTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DatabaseError : ApiError {
    private DatabaseErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DatabaseErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DatabaseError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum DatabaseErrorReason {
    CONCURRENT_MODIFICATION,
    PERMISSION_DENIED,
    CAMPAIGN_PRODUCT_NOT_SUPPORTED,
    DUPLICATE_KEY,
    DATABASE_ERROR,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class StringLengthError : ApiError {
    private StringLengthErrorReason reasonField;

    private bool reasonFieldSpecified;

    public StringLengthErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringLengthError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum StringLengthErrorReason {
    TOO_SHORT,
    TOO_LONG
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SizeLimitError : ApiError {
    private SizeLimitErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SizeLimitErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SizeLimitError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SizeLimitErrorReason {
    REQUEST_SIZE_LIMIT_EXCEEDED,
    RESPONSE_SIZE_LIMIT_EXCEEDED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SelectorError : ApiError {
    private SelectorErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SelectorErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SelectorError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SelectorErrorReason {
    INVALID_FIELD_NAME,
    MISSING_FIELDS,
    MISSING_PREDICATES,
    OPERATOR_DOES_NOT_SUPPORT_MULTIPLE_VALUES,
    INVALID_PREDICATE_ENUM_VALUE,
    MISSING_PREDICATE_OPERATOR,
    MISSING_PREDICATE_VALUES,
    INVALID_PREDICATE_FIELD_NAME,
    INVALID_PREDICATE_OPERATOR,
    INVALID_FIELD_SELECTION,
    INVALID_PREDICATE_VALUE,
    INVALID_SORT_FIELD_NAME,
    SELECTOR_ERROR,
    FILTER_BY_DATE_RANGE_NOT_SUPPORTED,
    START_INDEX_IS_TOO_HIGH,
    TOO_MANY_PREDICATE_VALUES,
    UNKNOWN_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RequiredError : ApiError {
    private RequiredErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RequiredErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RequiredError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RequiredErrorReason {
    REQUIRED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RequestError : ApiError {
    private RequestErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RequestErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RequestError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RequestErrorReason {
    UNKNOWN,
    INVALID_INPUT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RejectedError : ApiError {
    private RejectedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RejectedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RejectedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RejectedErrorReason {
    UNKNOWN_VALUE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RegionCodeError : ApiError {
    private RegionCodeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RegionCodeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RegionCodeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RegionCodeErrorReason {
    INVALID_REGION_CODE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ReadOnlyError : ApiError {
    private ReadOnlyErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ReadOnlyErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReadOnlyError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ReadOnlyErrorReason {
    READ_ONLY
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RateExceededError : ApiError {
    private RateExceededErrorReason reasonField;

    private bool reasonFieldSpecified;

    private string rateNameField;

    private string rateScopeField;

    private int retryAfterSecondsField;

    private bool retryAfterSecondsFieldSpecified;

    public RateExceededErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public string rateName {
      get { return this.rateNameField; }
      set { this.rateNameField = value; }
    }

    public string rateScope {
      get { return this.rateScopeField; }
      set { this.rateScopeField = value; }
    }

    public int retryAfterSeconds {
      get { return this.retryAfterSecondsField; }
      set {
        this.retryAfterSecondsField = value;
        this.retryAfterSecondsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool retryAfterSecondsSpecified {
      get { return this.retryAfterSecondsFieldSpecified; }
      set { this.retryAfterSecondsFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RateExceededError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RateExceededErrorReason {
    RATE_EXCEEDED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RangeError : ApiError {
    private RangeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public RangeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RangeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RangeErrorReason {
    TOO_LOW,
    TOO_HIGH
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class QuotaCheckError : ApiError {
    private QuotaCheckErrorReason reasonField;

    private bool reasonFieldSpecified;

    public QuotaCheckErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaCheckError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum QuotaCheckErrorReason {
    INVALID_TOKEN_HEADER,
    ACCOUNT_DELINQUENT,
    ACCOUNT_INACCESSIBLE,
    ACCOUNT_INACTIVE,
    INCOMPLETE_SIGNUP,
    DEVELOPER_TOKEN_NOT_APPROVED,
    TERMS_AND_CONDITIONS_NOT_SIGNED,
    MONTHLY_BUDGET_REACHED,
    QUOTA_EXCEEDED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class PagingError : ApiError {
    private PagingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public PagingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PagingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum PagingErrorReason {
    START_INDEX_CANNOT_BE_NEGATIVE,
    NUMBER_OF_RESULTS_CANNOT_BE_NEGATIVE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OperatorError : ApiError {
    private OperatorErrorReason reasonField;

    private bool reasonFieldSpecified;

    public OperatorErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OperatorError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum OperatorErrorReason {
    OPERATOR_NOT_SUPPORTED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OperationAccessDenied : ApiError {
    private OperationAccessDeniedReason reasonField;

    private bool reasonFieldSpecified;

    public OperationAccessDeniedReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OperationAccessDenied.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum OperationAccessDeniedReason {
    ACTION_NOT_PERMITTED,
    ADD_OPERATION_NOT_PERMITTED,
    REMOVE_OPERATION_NOT_PERMITTED,
    SET_OPERATION_NOT_PERMITTED,
    MUTATE_ACTION_NOT_PERMITTED_FOR_CLIENT,
    OPERATION_NOT_PERMITTED_FOR_CAMPAIGN_TYPE,
    ADD_AS_REMOVED_NOT_PERMITTED,
    OPERATION_NOT_PERMITTED_FOR_REMOVED_ENTITY,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class NullError : ApiError {
    private NullErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NullErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NullError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum NullErrorReason {
    NULL_CONTENT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class NotEmptyError : ApiError {
    private NotEmptyErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NotEmptyErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NotEmptyError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum NotEmptyErrorReason {
    EMPTY_LIST
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class NewEntityCreationError : ApiError {
    private NewEntityCreationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NewEntityCreationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NewEntityCreationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum NewEntityCreationErrorReason {
    CANNOT_SET_ID_FOR_ADD
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class InternalApiError : ApiError {
    private InternalApiErrorReason reasonField;

    private bool reasonFieldSpecified;

    public InternalApiErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "InternalApiError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum InternalApiErrorReason {
    UNEXPECTED_INTERNAL_API_ERROR,
    UNKNOWN,
    DOWNTIME
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class IdError : ApiError {
    private IdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public IdErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "IdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum IdErrorReason {
    NOT_FOUND
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class EntityNotFound : ApiError {
    private EntityNotFoundReason reasonField;

    private bool reasonFieldSpecified;

    public EntityNotFoundReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityNotFound.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum EntityNotFoundReason {
    INVALID_ID
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdCountLimitExceeded))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLimitExceeded))]
  public partial class EntityCountLimitExceeded : ApiError {
    private EntityCountLimitExceededReason reasonField;

    private bool reasonFieldSpecified;

    private string enclosingIdField;

    private int limitField;

    private bool limitFieldSpecified;

    private string accountLimitTypeField;

    private int existingCountField;

    private bool existingCountFieldSpecified;

    public EntityCountLimitExceededReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public string enclosingId {
      get { return this.enclosingIdField; }
      set { this.enclosingIdField = value; }
    }

    public int limit {
      get { return this.limitField; }
      set {
        this.limitField = value;
        this.limitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitSpecified {
      get { return this.limitFieldSpecified; }
      set { this.limitFieldSpecified = value; }
    }

    public string accountLimitType {
      get { return this.accountLimitTypeField; }
      set { this.accountLimitTypeField = value; }
    }

    public int existingCount {
      get { return this.existingCountField; }
      set {
        this.existingCountField = value;
        this.existingCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool existingCountSpecified {
      get { return this.existingCountFieldSpecified; }
      set { this.existingCountFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityCountLimitExceeded.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum EntityCountLimitExceededReason {
    ACCOUNT_LIMIT,
    CAMPAIGN_LIMIT,
    ADGROUP_LIMIT,
    AD_GROUP_AD_LIMIT,
    AD_GROUP_CRITERION_LIMIT,
    SHARED_SET_LIMIT,
    MATCHING_FUNCTION_LIMIT,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DistinctError : ApiError {
    private DistinctErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DistinctErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DistinctError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum DistinctErrorReason {
    DUPLICATE_ELEMENT,
    DUPLICATE_TYPE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ClientTermsError : ApiError {
    private ClientTermsErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ClientTermsErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ClientTermsError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ClientTermsErrorReason {
    INCOMPLETE_SIGNUP_CURRENT_ADWORDS_TNC_NOT_AGREED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignAdExtensionError : ApiError {
    private CampaignAdExtensionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignAdExtensionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignAdExtensionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignAdExtensionErrorReason {
    ADEXTENSION_NOT_UNDER_CAMPAIGN,
    CANNOT_ADD_REMOVED_CAMPAIGN_ADEXTENSION,
    CANNOT_OPERATE_ON_REMOVED_CAMPAIGN_ADEXTENSION,
    INVALID_ADEXTENSION_ID,
    MISSING_ADEXTENSION_ID,
    MUST_USE_CONCRETE_ADEXTENSION,
    UNKNOWN_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AuthorizationError : ApiError {
    private AuthorizationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AuthorizationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AuthorizationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AuthorizationErrorReason {
    UNABLE_TO_AUTHORIZE,
    NO_ADWORDS_ACCOUNT_FOR_CUSTOMER,
    USER_PERMISSION_DENIED,
    EFFECTIVE_USER_PERMISSION_DENIED,
    USER_HAS_READONLY_PERMISSION,
    NO_CUSTOMER_FOUND,
    SERVICE_ACCESS_DENIED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AuthenticationError : ApiError {
    private AuthenticationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AuthenticationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AuthenticationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AuthenticationErrorReason {
    AUTHENTICATION_FAILED,
    CLIENT_CUSTOMER_ID_IS_REQUIRED,
    CLIENT_EMAIL_REQUIRED,
    CLIENT_CUSTOMER_ID_INVALID,
    CLIENT_EMAIL_INVALID,
    CLIENT_EMAIL_FAILED_TO_AUTHENTICATE,
    CUSTOMER_NOT_FOUND,
    GOOGLE_ACCOUNT_DELETED,
    GOOGLE_ACCOUNT_COOKIE_INVALID,
    FAILED_TO_AUTHENTICATE_GOOGLE_ACCOUNT,
    GOOGLE_ACCOUNT_USER_AND_ADS_USER_MISMATCH,
    LOGIN_COOKIE_REQUIRED,
    NOT_ADS_USER,
    OAUTH_TOKEN_INVALID,
    OAUTH_TOKEN_EXPIRED,
    OAUTH_TOKEN_DISABLED,
    OAUTH_TOKEN_REVOKED,
    OAUTH_TOKEN_HEADER_INVALID,
    LOGIN_COOKIE_INVALID,
    FAILED_TO_RETRIEVE_LOGIN_COOKIE,
    USER_ID_INVALID
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdxError : ApiError {
    private AdxErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdxErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdxError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdxErrorReason {
    UNSUPPORTED_FEATURE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdExtensionError : ApiError {
    private AdExtensionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdExtensionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdExtensionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdExtensionErrorReason {
    ACCOUNT_DELETED,
    AD_EXTENSION_NO_LONGER_ACTIVE,
    CANNOT_HAVE_MULTIPLE_LOCATION_SYNC_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_MOBILE_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_PRODUCT_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_SITELINKS_EXTENSIONS_PER_CAMPAIGN,
    CANNOT_HAVE_MULTIPLE_IN_APP_LINK_EXTENSIONS_PER_CAMPAIGN_PER_APPSTORE,
    INVALID_ADEXTENSION_TYPE,
    INVALID_AUTH_TOKEN_FOR_EMAIL,
    INVALID_COUNTRY_CODE,
    INVALID_DOMESTIC_PHONE_NUMBER_FORMAT,
    INVALID_DESTINATION_URL,
    INVALID_EMAIL,
    INVALID_ENCODED_LOCATION,
    INVALID_ENUM_CONDITION_OPERATOR,
    INVALID_ICON_DIMENSIONS,
    INVALID_ID,
    INVALID_IMAGE_DIMENSIONS,
    INVALID_INPUT,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    INVALID_PHONE_NUMBER,
    INVALID_STRING_CONDITION_OPERATOR,
    INVALID_TOLL_PHONE_NUMBER_FORMAT,
    MEDIA_DOES_NOT_BELONG_TO_ACCOUNT,
    MEDIA_NOT_ICON_TYPE,
    MEDIA_NOT_IMAGE_TYPE,
    MISSING_ADVERTISER_NAME,
    MISSING_AUTH_TOKEN,
    MISSING_COUNTRY_CODE,
    MISSING_CITY_NAME,
    MISSING_EMAIL,
    MISSING_ENCODED_LOCATION,
    MISSING_CONDITION_OPERAND,
    MISSING_CONDITION_STRING_VALUE,
    MISSING_POSTAL_CODE,
    MISSING_STREET_ADDRESS,
    NUM_AND_GROUPS_OVER_LIMIT,
    NUM_CONDITIONS_OVER_LIMIT,
    NUM_LOCATION_EXTENSIONS_OVER_LIMIT,
    NOT_AUTHORIZED_TO_CREATE_EXTENSION,
    PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY,
    DISALLOWED_NUMBER_TYPE,
    PREMIUM_RATE_NUMBER_NOT_ALLOWED,
    TOO_LONG,
    USER_NOT_PERMITTED_TO_CREATE_LBC_SYNC_LOCATION_EXTENSION
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionOperation))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignLabelOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignFeedOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerFeedOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdLabelOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedItemOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedMappingOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManagedCustomerOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MoveOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinkOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignTargetOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupLabelOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionLabelOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidModifierOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OfflineConversionFeedOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupFeedOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpressBusinessOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PromotionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignSharedSetOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedCriterionOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedSetOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingStrategyOperation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOrderOperation))]
  public abstract partial class Operation {
    private Operator operatorField;

    private bool operatorFieldSpecified;

    private string operationTypeField;

    public Operator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Operation.Type")]
    public string OperationType {
      get { return this.operationTypeField; }
      set { this.operationTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum Operator {
    ADD,
    REMOVE,
    SET
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignAdExtensionOperation : Operation {
    private CampaignAdExtension operandField;

    public CampaignAdExtension operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignAdExtensionPage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignCriterionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NullStatsPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignFeedPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NoStatsPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerFeedPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainCategoryPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupAdPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExperimentPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedItemPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedMappingPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManagedCustomerPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupFeedPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserListPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpressNoStatsPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpressBusinessPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PromotionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductServicePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignSharedSetPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedCriterionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupCriterionPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedSetPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidModifierPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddingStrategyPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOrderPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetPage))]
  public abstract partial class Page {
    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    private string pageTypeField;

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Page.Type")]
    public string PageType {
      get { return this.pageTypeField; }
      set { this.pageTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignAdExtensionPage : Page {
    private CampaignAdExtension[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignAdExtension[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Paging {
    private int startIndexField;

    private bool startIndexFieldSpecified;

    private int numberResultsField;

    private bool numberResultsFieldSpecified;

    public int startIndex {
      get { return this.startIndexField; }
      set {
        this.startIndexField = value;
        this.startIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startIndexSpecified {
      get { return this.startIndexFieldSpecified; }
      set { this.startIndexFieldSpecified = value; }
    }

    public int numberResults {
      get { return this.numberResultsField; }
      set {
        this.numberResultsField = value;
        this.numberResultsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberResultsSpecified {
      get { return this.numberResultsFieldSpecified; }
      set { this.numberResultsFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OrderBy {
    private string fieldField;

    private SortOrder sortOrderField;

    private bool sortOrderFieldSpecified;

    public string field {
      get { return this.fieldField; }
      set { this.fieldField = value; }
    }

    public SortOrder sortOrder {
      get { return this.sortOrderField; }
      set {
        this.sortOrderField = value;
        this.sortOrderSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sortOrderSpecified {
      get { return this.sortOrderFieldSpecified; }
      set { this.sortOrderFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SortOrder {
    ASCENDING,
    DESCENDING
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DateRange {
    private string minField;

    private string maxField;

    public string min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public string max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Predicate {
    private string fieldField;

    private PredicateOperator operatorField;

    private bool operatorFieldSpecified;

    private string[] valuesField;

    public string field {
      get { return this.fieldField; }
      set { this.fieldField = value; }
    }

    public PredicateOperator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("values")]
    public string[] values {
      get { return this.valuesField; }
      set { this.valuesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Predicate.Operator", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum PredicateOperator {
    EQUALS,
    NOT_EQUALS,
    IN,
    NOT_IN,
    GREATER_THAN,
    GREATER_THAN_EQUALS,
    LESS_THAN,
    LESS_THAN_EQUALS,
    STARTS_WITH,
    STARTS_WITH_IGNORE_CASE,
    CONTAINS,
    CONTAINS_IGNORE_CASE,
    DOES_NOT_CONTAIN,
    DOES_NOT_CONTAIN_IGNORE_CASE,
    CONTAINS_ANY,
    CONTAINS_ALL,
    CONTAINS_NONE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Selector {
    private string[] fieldsField;

    private Predicate[] predicatesField;

    private DateRange dateRangeField;

    private OrderBy[] orderingField;

    private Paging pagingField;

    [System.Xml.Serialization.XmlElementAttribute("fields")]
    public string[] fields {
      get { return this.fieldsField; }
      set { this.fieldsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("predicates")]
    public Predicate[] predicates {
      get { return this.predicatesField; }
      set { this.predicatesField = value; }
    }

    public DateRange dateRange {
      get { return this.dateRangeField; }
      set { this.dateRangeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ordering")]
    public OrderBy[] ordering {
      get { return this.orderingField; }
      set { this.orderingField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApiException))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ApplicationException {
    private string messageField;

    private string applicationExceptionTypeField;

    public string message {
      get { return this.messageField; }
      set { this.messageField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ApplicationException.Type")]
    public string ApplicationExceptionType {
      get { return this.applicationExceptionTypeField; }
      set { this.applicationExceptionTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ApiException : ApplicationException {
    private ApiError[] errorsField;

    [System.Xml.Serialization.XmlElementAttribute("errors")]
    public ApiError[] errors {
      get { return this.errorsField; }
      set { this.errorsField = value; }
    }
  }



















  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignCriterionService : AdWordsSoapClient, ICampaignCriterionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/CampaignCriterionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignCriterionPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((CampaignCriterionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignCriterionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignCriterionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((CampaignCriterionReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignCriterionPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((CampaignCriterionPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignCriterionReturnValue : ListReturnValue {
    private CampaignCriterion[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignCriterion[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeCampaignCriterion))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignCriterion {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private bool isNegativeField;

    private bool isNegativeFieldSpecified;

    private Criterion criterionField;

    private double bidModifierField;

    private bool bidModifierFieldSpecified;

    private String_StringMapEntry[] forwardCompatibilityMapField;

    private string campaignCriterionTypeField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public bool isNegative {
      get { return this.isNegativeField; }
      set {
        this.isNegativeField = value;
        this.isNegativeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isNegativeSpecified {
      get { return this.isNegativeFieldSpecified; }
      set { this.isNegativeFieldSpecified = value; }
    }

    public Criterion criterion {
      get { return this.criterionField; }
      set { this.criterionField = value; }
    }

    public double bidModifier {
      get { return this.bidModifierField; }
      set {
        this.bidModifierField = value;
        this.bidModifierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidModifierSpecified {
      get { return this.bidModifierFieldSpecified; }
      set { this.bidModifierFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("forwardCompatibilityMap")]
    public String_StringMapEntry[] forwardCompatibilityMap {
      get { return this.forwardCompatibilityMapField; }
      set { this.forwardCompatibilityMapField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterion.Type")]
    public string CampaignCriterionType {
      get { return this.campaignCriterionTypeField; }
      set { this.campaignCriterionTypeField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Webpage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Vertical))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionUserInterest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationGroups))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Proximity))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductScope))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Platform))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Placement))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OperatingSystemVersion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileDevice))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileApplication))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileAppCategory))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Language))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Keyword))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IpBlock))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Gender))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContentLabel))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Carrier))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AgeRange))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdSchedule))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductPartition))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppPaymentModel))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeKeyword))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductService))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeCriterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordSet))]
  public partial class Criterion {
    private long idField;

    private bool idFieldSpecified;

    private CriterionType typeField;

    private bool typeFieldSpecified;

    private string criterionTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public CriterionType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Criterion.Type")]
    public string CriterionType {
      get { return this.criterionTypeField; }
      set { this.criterionTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Criterion.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CriterionType {
    CONTENT_LABEL,
    KEYWORD,
    PLACEMENT,
    VERTICAL,
    USER_LIST,
    USER_INTEREST,
    MOBILE_APPLICATION,
    MOBILE_APP_CATEGORY,
    PRODUCT,
    PRODUCT_PARTITION,
    IP_BLOCK,
    WEBPAGE,
    LANGUAGE,
    LOCATION,
    AGE_RANGE,
    CARRIER,
    OPERATING_SYSTEM_VERSION,
    MOBILE_DEVICE,
    GENDER,
    PROXIMITY,
    PLATFORM,
    AD_SCHEDULE,
    LOCATION_GROUPS,
    PRODUCT_SCOPE,
    APP_PAYMENT_MODEL,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Webpage : Criterion {
    private WebpageParameter parameterField;

    private double criteriaCoverageField;

    private bool criteriaCoverageFieldSpecified;

    private string[] criteriaSamplesField;

    public WebpageParameter parameter {
      get { return this.parameterField; }
      set { this.parameterField = value; }
    }

    public double criteriaCoverage {
      get { return this.criteriaCoverageField; }
      set {
        this.criteriaCoverageField = value;
        this.criteriaCoverageSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criteriaCoverageSpecified {
      get { return this.criteriaCoverageFieldSpecified; }
      set { this.criteriaCoverageFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("criteriaSamples")]
    public string[] criteriaSamples {
      get { return this.criteriaSamplesField; }
      set { this.criteriaSamplesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class WebpageParameter : CriterionParameter {
    private string criterionNameField;

    private WebpageCondition[] conditionsField;

    public string criterionName {
      get { return this.criterionNameField; }
      set { this.criterionNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("conditions")]
    public WebpageCondition[] conditions {
      get { return this.conditionsField; }
      set { this.conditionsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class WebpageCondition {
    private WebpageConditionOperand operandField;

    private bool operandFieldSpecified;

    private string argumentField;

    public WebpageConditionOperand operand {
      get { return this.operandField; }
      set {
        this.operandField = value;
        this.operandSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operandSpecified {
      get { return this.operandFieldSpecified; }
      set { this.operandFieldSpecified = value; }
    }

    public string argument {
      get { return this.argumentField; }
      set { this.argumentField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum WebpageConditionOperand {
    URL,
    CATEGORY,
    PAGE_TITLE,
    PAGE_CONTENT,
    UNKNOWN
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebpageParameter))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class CriterionParameter {
    private string criterionParameterTypeField;

    [System.Xml.Serialization.XmlElementAttribute("CriterionParameter.Type")]
    public string CriterionParameterType {
      get { return this.criterionParameterTypeField; }
      set { this.criterionParameterTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Vertical : Criterion {
    private long verticalIdField;

    private bool verticalIdFieldSpecified;

    private long verticalParentIdField;

    private bool verticalParentIdFieldSpecified;

    private string[] pathField;

    public long verticalId {
      get { return this.verticalIdField; }
      set {
        this.verticalIdField = value;
        this.verticalIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool verticalIdSpecified {
      get { return this.verticalIdFieldSpecified; }
      set { this.verticalIdFieldSpecified = value; }
    }

    public long verticalParentId {
      get { return this.verticalParentIdField; }
      set {
        this.verticalParentIdField = value;
        this.verticalParentIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool verticalParentIdSpecified {
      get { return this.verticalParentIdFieldSpecified; }
      set { this.verticalParentIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("path")]
    public string[] path {
      get { return this.pathField; }
      set { this.pathField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CriterionUserList : Criterion {
    private long userListIdField;

    private bool userListIdFieldSpecified;

    private string userListNameField;

    private CriterionUserListMembershipStatus userListMembershipStatusField;

    private bool userListMembershipStatusFieldSpecified;

    public long userListId {
      get { return this.userListIdField; }
      set {
        this.userListIdField = value;
        this.userListIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userListIdSpecified {
      get { return this.userListIdFieldSpecified; }
      set { this.userListIdFieldSpecified = value; }
    }

    public string userListName {
      get { return this.userListNameField; }
      set { this.userListNameField = value; }
    }

    public CriterionUserListMembershipStatus userListMembershipStatus {
      get { return this.userListMembershipStatusField; }
      set {
        this.userListMembershipStatusField = value;
        this.userListMembershipStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userListMembershipStatusSpecified {
      get { return this.userListMembershipStatusFieldSpecified; }
      set { this.userListMembershipStatusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CriterionUserList.MembershipStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CriterionUserListMembershipStatus {
    OPEN,
    CLOSED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CriterionUserInterest : Criterion {
    private long userInterestIdField;

    private bool userInterestIdFieldSpecified;

    private string userInterestNameField;

    public long userInterestId {
      get { return this.userInterestIdField; }
      set {
        this.userInterestIdField = value;
        this.userInterestIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userInterestIdSpecified {
      get { return this.userInterestIdFieldSpecified; }
      set { this.userInterestIdFieldSpecified = value; }
    }

    public string userInterestName {
      get { return this.userInterestNameField; }
      set { this.userInterestNameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LocationGroups : Criterion {
    private Function matchingFunctionField;

    public Function matchingFunction {
      get { return this.matchingFunctionField; }
      set { this.matchingFunctionField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Function {
    private FunctionOperator operatorField;

    private bool operatorFieldSpecified;

    private FunctionArgumentOperand[] lhsOperandField;

    private FunctionArgumentOperand[] rhsOperandField;

    public FunctionOperator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("lhsOperand")]
    public FunctionArgumentOperand[] lhsOperand {
      get { return this.lhsOperandField; }
      set { this.lhsOperandField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("rhsOperand")]
    public FunctionArgumentOperand[] rhsOperand {
      get { return this.rhsOperandField; }
      set { this.rhsOperandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Function.Operator", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FunctionOperator {
    IN,
    IDENTITY,
    EQUALS,
    AND,
    CONTAINS_ANY,
    UNKNOWN
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacesOfInterestOperand))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationExtensionOperand))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IncomeOperand))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoTargetOperand))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstantOperand))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestContextOperand))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionOperand))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedAttributeOperand))]
  public abstract partial class FunctionArgumentOperand {
    private string functionArgumentOperandTypeField;

    [System.Xml.Serialization.XmlElementAttribute("FunctionArgumentOperand.Type")]
    public string FunctionArgumentOperandType {
      get { return this.functionArgumentOperandTypeField; }
      set { this.functionArgumentOperandTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class PlacesOfInterestOperand : FunctionArgumentOperand {
    private PlacesOfInterestOperandCategory categoryField;

    private bool categoryFieldSpecified;

    public PlacesOfInterestOperandCategory category {
      get { return this.categoryField; }
      set {
        this.categoryField = value;
        this.categorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categorySpecified {
      get { return this.categoryFieldSpecified; }
      set { this.categoryFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PlacesOfInterestOperand.Category", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum PlacesOfInterestOperandCategory {
    AIRPORT,
    DOWNTOWN,
    UNIVERSITY,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LocationExtensionOperand : FunctionArgumentOperand {
    private ConstantOperand radiusField;

    public ConstantOperand radius {
      get { return this.radiusField; }
      set { this.radiusField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConstantOperand : FunctionArgumentOperand {
    private ConstantOperandConstantType typeField;

    private bool typeFieldSpecified;

    private ConstantOperandUnit unitField;

    private bool unitFieldSpecified;

    private long longValueField;

    private bool longValueFieldSpecified;

    private bool booleanValueField;

    private bool booleanValueFieldSpecified;

    private double doubleValueField;

    private bool doubleValueFieldSpecified;

    private string stringValueField;

    public ConstantOperandConstantType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public ConstantOperandUnit unit {
      get { return this.unitField; }
      set {
        this.unitField = value;
        this.unitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool unitSpecified {
      get { return this.unitFieldSpecified; }
      set { this.unitFieldSpecified = value; }
    }

    public long longValue {
      get { return this.longValueField; }
      set {
        this.longValueField = value;
        this.longValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool longValueSpecified {
      get { return this.longValueFieldSpecified; }
      set { this.longValueFieldSpecified = value; }
    }

    public bool booleanValue {
      get { return this.booleanValueField; }
      set {
        this.booleanValueField = value;
        this.booleanValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool booleanValueSpecified {
      get { return this.booleanValueFieldSpecified; }
      set { this.booleanValueFieldSpecified = value; }
    }

    public double doubleValue {
      get { return this.doubleValueField; }
      set {
        this.doubleValueField = value;
        this.doubleValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool doubleValueSpecified {
      get { return this.doubleValueFieldSpecified; }
      set { this.doubleValueFieldSpecified = value; }
    }

    public string stringValue {
      get { return this.stringValueField; }
      set { this.stringValueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConstantOperand.ConstantType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConstantOperandConstantType {
    BOOLEAN,
    DOUBLE,
    LONG,
    STRING
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConstantOperand.Unit", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConstantOperandUnit {
    METERS,
    MILES,
    NONE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class IncomeOperand : FunctionArgumentOperand {
    private IncomeTier tierField;

    private bool tierFieldSpecified;

    public IncomeTier tier {
      get { return this.tierField; }
      set {
        this.tierField = value;
        this.tierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool tierSpecified {
      get { return this.tierFieldSpecified; }
      set { this.tierFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum IncomeTier {
    UNKNOWN,
    TIER_1,
    TIER_2,
    TIER_3,
    TIER_4,
    TIER_5,
    TIER_6_TO_10
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class GeoTargetOperand : FunctionArgumentOperand {
    private long[] locationsField;

    [System.Xml.Serialization.XmlElementAttribute("locations")]
    public long[] locations {
      get { return this.locationsField; }
      set { this.locationsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Proximity : Criterion {
    private GeoPoint geoPointField;

    private ProximityDistanceUnits radiusDistanceUnitsField;

    private bool radiusDistanceUnitsFieldSpecified;

    private double radiusInUnitsField;

    private bool radiusInUnitsFieldSpecified;

    private Address addressField;

    public GeoPoint geoPoint {
      get { return this.geoPointField; }
      set { this.geoPointField = value; }
    }

    public ProximityDistanceUnits radiusDistanceUnits {
      get { return this.radiusDistanceUnitsField; }
      set {
        this.radiusDistanceUnitsField = value;
        this.radiusDistanceUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusDistanceUnitsSpecified {
      get { return this.radiusDistanceUnitsFieldSpecified; }
      set { this.radiusDistanceUnitsFieldSpecified = value; }
    }

    public double radiusInUnits {
      get { return this.radiusInUnitsField; }
      set {
        this.radiusInUnitsField = value;
        this.radiusInUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool radiusInUnitsSpecified {
      get { return this.radiusInUnitsFieldSpecified; }
      set { this.radiusInUnitsFieldSpecified = value; }
    }

    public Address address {
      get { return this.addressField; }
      set { this.addressField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Proximity.DistanceUnits", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ProximityDistanceUnits {
    KILOMETERS,
    MILES
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductScope : Criterion {
    private ProductDimension[] dimensionsField;

    [System.Xml.Serialization.XmlElementAttribute("dimensions")]
    public ProductDimension[] dimensions {
      get { return this.dimensionsField; }
      set { this.dimensionsField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductTypeFull))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductOfferId))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductCustomAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductLegacyCondition))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductCanonicalCondition))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductBrand))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductBiddingCategory))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductAdwordsLabels))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductAdwordsGrouping))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class ProductDimension {
    private string productDimensionTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ProductDimension.Type")]
    public string ProductDimensionType {
      get { return this.productDimensionTypeField; }
      set { this.productDimensionTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductTypeFull : ProductDimension {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductType : ProductDimension {
    private ProductDimensionType typeField;

    private bool typeFieldSpecified;

    private string valueField;

    public ProductDimensionType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ProductDimensionType {
    UNKNOWN,
    BIDDING_CATEGORY_L1,
    BIDDING_CATEGORY_L2,
    BIDDING_CATEGORY_L3,
    BIDDING_CATEGORY_L4,
    BIDDING_CATEGORY_L5,
    BRAND,
    CANONICAL_CONDITION,
    CUSTOM_ATTRIBUTE_0,
    CUSTOM_ATTRIBUTE_1,
    CUSTOM_ATTRIBUTE_2,
    CUSTOM_ATTRIBUTE_3,
    CUSTOM_ATTRIBUTE_4,
    OFFER_ID,
    PRODUCT_TYPE_L1,
    PRODUCT_TYPE_L2,
    PRODUCT_TYPE_L3,
    PRODUCT_TYPE_L4,
    PRODUCT_TYPE_L5
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductOfferId : ProductDimension {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductCustomAttribute : ProductDimension {
    private ProductDimensionType typeField;

    private bool typeFieldSpecified;

    private string valueField;

    public ProductDimensionType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductLegacyCondition : ProductDimension {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductCanonicalCondition : ProductDimension {
    private ProductCanonicalConditionCondition conditionField;

    private bool conditionFieldSpecified;

    public ProductCanonicalConditionCondition condition {
      get { return this.conditionField; }
      set {
        this.conditionField = value;
        this.conditionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conditionSpecified {
      get { return this.conditionFieldSpecified; }
      set { this.conditionFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ProductCanonicalCondition.Condition", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ProductCanonicalConditionCondition {
    NEW,
    USED,
    REFURBISHED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductBrand : ProductDimension {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductBiddingCategory : ProductDimension {
    private ProductDimensionType typeField;

    private bool typeFieldSpecified;

    private long valueField;

    private bool valueFieldSpecified;

    public ProductDimensionType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public long value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductAdwordsLabels : ProductDimension {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductAdwordsGrouping : ProductDimension {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Product : Criterion {
    private ProductCondition[] conditionsField;

    private string textField;

    [System.Xml.Serialization.XmlElementAttribute("conditions")]
    public ProductCondition[] conditions {
      get { return this.conditionsField; }
      set { this.conditionsField = value; }
    }

    public string text {
      get { return this.textField; }
      set { this.textField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductCondition {
    private string argumentField;

    private ProductConditionOperand operandField;

    public string argument {
      get { return this.argumentField; }
      set { this.argumentField = value; }
    }

    public ProductConditionOperand operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductConditionOperand {
    private string operandField;

    public string operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Platform : Criterion {
    private string platformNameField;

    public string platformName {
      get { return this.platformNameField; }
      set { this.platformNameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Placement : Criterion {
    private string urlField;

    public string url {
      get { return this.urlField; }
      set { this.urlField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OperatingSystemVersion : Criterion {
    private string nameField;

    private int osMajorVersionField;

    private bool osMajorVersionFieldSpecified;

    private int osMinorVersionField;

    private bool osMinorVersionFieldSpecified;

    private OperatingSystemVersionOperatorType operatorTypeField;

    private bool operatorTypeFieldSpecified;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public int osMajorVersion {
      get { return this.osMajorVersionField; }
      set {
        this.osMajorVersionField = value;
        this.osMajorVersionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool osMajorVersionSpecified {
      get { return this.osMajorVersionFieldSpecified; }
      set { this.osMajorVersionFieldSpecified = value; }
    }

    public int osMinorVersion {
      get { return this.osMinorVersionField; }
      set {
        this.osMinorVersionField = value;
        this.osMinorVersionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool osMinorVersionSpecified {
      get { return this.osMinorVersionFieldSpecified; }
      set { this.osMinorVersionFieldSpecified = value; }
    }

    public OperatingSystemVersionOperatorType operatorType {
      get { return this.operatorTypeField; }
      set {
        this.operatorTypeField = value;
        this.operatorTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorTypeSpecified {
      get { return this.operatorTypeFieldSpecified; }
      set { this.operatorTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OperatingSystemVersion.OperatorType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum OperatingSystemVersionOperatorType {
    GREATER_THAN_EQUAL_TO,
    EQUAL_TO,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MobileDevice : Criterion {
    private string deviceNameField;

    private string manufacturerNameField;

    private MobileDeviceDeviceType deviceTypeField;

    private bool deviceTypeFieldSpecified;

    private string operatingSystemNameField;

    public string deviceName {
      get { return this.deviceNameField; }
      set { this.deviceNameField = value; }
    }

    public string manufacturerName {
      get { return this.manufacturerNameField; }
      set { this.manufacturerNameField = value; }
    }

    public MobileDeviceDeviceType deviceType {
      get { return this.deviceTypeField; }
      set {
        this.deviceTypeField = value;
        this.deviceTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deviceTypeSpecified {
      get { return this.deviceTypeFieldSpecified; }
      set { this.deviceTypeFieldSpecified = value; }
    }

    public string operatingSystemName {
      get { return this.operatingSystemNameField; }
      set { this.operatingSystemNameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MobileDevice.DeviceType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MobileDeviceDeviceType {
    DEVICE_TYPE_MOBILE,
    DEVICE_TYPE_TABLET
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MobileApplication : Criterion {
    private string appIdField;

    private string displayNameField;

    public string appId {
      get { return this.appIdField; }
      set { this.appIdField = value; }
    }

    public string displayName {
      get { return this.displayNameField; }
      set { this.displayNameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MobileAppCategory : Criterion {
    private int mobileAppCategoryIdField;

    private bool mobileAppCategoryIdFieldSpecified;

    private string displayNameField;

    public int mobileAppCategoryId {
      get { return this.mobileAppCategoryIdField; }
      set {
        this.mobileAppCategoryIdField = value;
        this.mobileAppCategoryIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mobileAppCategoryIdSpecified {
      get { return this.mobileAppCategoryIdFieldSpecified; }
      set { this.mobileAppCategoryIdFieldSpecified = value; }
    }

    public string displayName {
      get { return this.displayNameField; }
      set { this.displayNameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Location : Criterion {
    private string locationNameField;

    private string displayTypeField;

    private LocationTargetingStatus targetingStatusField;

    private bool targetingStatusFieldSpecified;

    private Location[] parentLocationsField;

    public string locationName {
      get { return this.locationNameField; }
      set { this.locationNameField = value; }
    }

    public string displayType {
      get { return this.displayTypeField; }
      set { this.displayTypeField = value; }
    }

    public LocationTargetingStatus targetingStatus {
      get { return this.targetingStatusField; }
      set {
        this.targetingStatusField = value;
        this.targetingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetingStatusSpecified {
      get { return this.targetingStatusFieldSpecified; }
      set { this.targetingStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("parentLocations")]
    public Location[] parentLocations {
      get { return this.parentLocationsField; }
      set { this.parentLocationsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum LocationTargetingStatus {
    ACTIVE,
    OBSOLETE,
    PHASING_OUT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Language : Criterion {
    private string codeField;

    private string nameField;

    public string code {
      get { return this.codeField; }
      set { this.codeField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeKeyword))]
  public partial class Keyword : Criterion {
    private string textField;

    private KeywordMatchType matchTypeField;

    private bool matchTypeFieldSpecified;

    public string text {
      get { return this.textField; }
      set { this.textField = value; }
    }

    public KeywordMatchType matchType {
      get { return this.matchTypeField; }
      set {
        this.matchTypeField = value;
        this.matchTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool matchTypeSpecified {
      get { return this.matchTypeFieldSpecified; }
      set { this.matchTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum KeywordMatchType {
    EXACT,
    PHRASE,
    BROAD
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class IpBlock : Criterion {
    private string ipAddressField;

    public string ipAddress {
      get { return this.ipAddressField; }
      set { this.ipAddressField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Gender : Criterion {
    private GenderGenderType genderTypeField;

    private bool genderTypeFieldSpecified;

    public GenderGenderType genderType {
      get { return this.genderTypeField; }
      set {
        this.genderTypeField = value;
        this.genderTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool genderTypeSpecified {
      get { return this.genderTypeFieldSpecified; }
      set { this.genderTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Gender.GenderType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum GenderGenderType {
    GENDER_MALE,
    GENDER_FEMALE,
    GENDER_UNDETERMINED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ContentLabel : Criterion {
    private ContentLabelType contentLabelTypeField;

    private bool contentLabelTypeFieldSpecified;

    public ContentLabelType contentLabelType {
      get { return this.contentLabelTypeField; }
      set {
        this.contentLabelTypeField = value;
        this.contentLabelTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool contentLabelTypeSpecified {
      get { return this.contentLabelTypeFieldSpecified; }
      set { this.contentLabelTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ContentLabelType {
    ADULTISH,
    AFE,
    BELOW_THE_FOLD,
    CONFLICT,
    DP,
    EMBEDDED_VIDEO,
    GAMES,
    JACKASS,
    PROFANITY,
    UGC_FORUMS,
    UGC_IMAGES,
    UGC_SOCIAL,
    UGC_VIDEOS,
    SIRENS,
    TRAGEDY,
    VIDEO,
    VIDEO_RATING_DV_G,
    VIDEO_RATING_DV_PG,
    VIDEO_RATING_DV_T,
    VIDEO_RATING_DV_MA,
    VIDEO_NOT_YET_RATED,
    LIVE_STREAMING_VIDEO,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Carrier : Criterion {
    private string nameField;

    private string countryCodeField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AgeRange : Criterion {
    private AgeRangeAgeRangeType ageRangeTypeField;

    private bool ageRangeTypeFieldSpecified;

    public AgeRangeAgeRangeType ageRangeType {
      get { return this.ageRangeTypeField; }
      set {
        this.ageRangeTypeField = value;
        this.ageRangeTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ageRangeTypeSpecified {
      get { return this.ageRangeTypeFieldSpecified; }
      set { this.ageRangeTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AgeRange.AgeRangeType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AgeRangeAgeRangeType {
    AGE_RANGE_18_24,
    AGE_RANGE_25_34,
    AGE_RANGE_35_44,
    AGE_RANGE_45_54,
    AGE_RANGE_55_64,
    AGE_RANGE_65_UP,
    AGE_RANGE_UNDETERMINED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdSchedule : Criterion {
    private DayOfWeek dayOfWeekField;

    private bool dayOfWeekFieldSpecified;

    private int startHourField;

    private bool startHourFieldSpecified;

    private MinuteOfHour startMinuteField;

    private bool startMinuteFieldSpecified;

    private int endHourField;

    private bool endHourFieldSpecified;

    private MinuteOfHour endMinuteField;

    private bool endMinuteFieldSpecified;

    public DayOfWeek dayOfWeek {
      get { return this.dayOfWeekField; }
      set {
        this.dayOfWeekField = value;
        this.dayOfWeekSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool dayOfWeekSpecified {
      get { return this.dayOfWeekFieldSpecified; }
      set { this.dayOfWeekFieldSpecified = value; }
    }

    public int startHour {
      get { return this.startHourField; }
      set {
        this.startHourField = value;
        this.startHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startHourSpecified {
      get { return this.startHourFieldSpecified; }
      set { this.startHourFieldSpecified = value; }
    }

    public MinuteOfHour startMinute {
      get { return this.startMinuteField; }
      set {
        this.startMinuteField = value;
        this.startMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startMinuteSpecified {
      get { return this.startMinuteFieldSpecified; }
      set { this.startMinuteFieldSpecified = value; }
    }

    public int endHour {
      get { return this.endHourField; }
      set {
        this.endHourField = value;
        this.endHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endHourSpecified {
      get { return this.endHourFieldSpecified; }
      set { this.endHourFieldSpecified = value; }
    }

    public MinuteOfHour endMinute {
      get { return this.endMinuteField; }
      set {
        this.endMinuteField = value;
        this.endMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endMinuteSpecified {
      get { return this.endMinuteFieldSpecified; }
      set { this.endMinuteFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum DayOfWeek {
    MONDAY,
    TUESDAY,
    WEDNESDAY,
    THURSDAY,
    FRIDAY,
    SATURDAY,
    SUNDAY
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MinuteOfHour {
    ZERO,
    FIFTEEN,
    THIRTY,
    FORTY_FIVE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class String_StringMapEntry {
    private string keyField;

    private string valueField;

    public string key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class NegativeCampaignCriterion : CampaignCriterion {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class QueryError : ApiError {
    private QueryErrorReason reasonField;

    private bool reasonFieldSpecified;

    private string messageField;

    public QueryErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public string message {
      get { return this.messageField; }
      set { this.messageField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QueryError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum QueryErrorReason {
    PARSING_FAILED,
    MISSING_QUERY,
    MISSING_SELECT_CLAUSE,
    MISSING_FROM_CLAUSE,
    INVALID_SELECT_CLAUSE,
    INVALID_FROM_CLAUSE,
    INVALID_WHERE_CLAUSE,
    INVALID_ORDER_BY_CLAUSE,
    INVALID_LIMIT_CLAUSE,
    INVALID_START_INDEX_IN_LIMIT_CLAUSE,
    INVALID_PAGE_SIZE_IN_LIMIT_CLAUSE,
    INVALID_DURING_CLAUSE,
    INVALID_MIN_DATE_IN_DURING_CLAUSE,
    INVALID_MAX_DATE_IN_DURING_CLAUSE,
    MAX_LESS_THAN_MIN_IN_DURING_CLAUSE,
    VALIDATION_FAILED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FunctionError : ApiError {
    private FunctionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public FunctionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FunctionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FunctionErrorReason {
    INVALID_FUNCTION_FORMAT,
    DATA_TYPE_MISMATCH,
    INVALID_CONJUNCTION_OPERANDS,
    INVALID_NUMBER_OF_OPERANDS,
    INVALID_OPERAND_TYPE,
    INVALID_OPERATOR,
    INVALID_REQUEST_CONTEXT_TYPE,
    INVALID_FUNCTION_FOR_CALL_PLACEHOLDER,
    INVALID_FUNCTION_FOR_PLACEHOLDER,
    INVALID_OPERAND,
    MISSING_CONSTANT_OPERAND_VALUE,
    INVALID_CONSTANT_OPERAND_VALUE,
    INVALID_NESTING,
    MULTIPLE_FEED_IDS_NOT_SUPPORTED,
    INVALID_ATTRIBUTE_NAME,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CriterionError : ApiError {
    private CriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CriterionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CriterionErrorReason {
    CONCRETE_TYPE_REQUIRED,
    INVALID_EXCLUDED_CATEGORY,
    INVALID_KEYWORD_TEXT,
    KEYWORD_TEXT_TOO_LONG,
    KEYWORD_HAS_TOO_MANY_WORDS,
    KEYWORD_HAS_INVALID_CHARS,
    INVALID_PLACEMENT_URL,
    INVALID_USER_LIST,
    INVALID_USER_INTEREST,
    INVALID_FORMAT_FOR_PLACEMENT_URL,
    PLACEMENT_URL_IS_TOO_LONG,
    PLACEMENT_URL_HAS_ILLEGAL_CHAR,
    PLACEMENT_URL_HAS_MULTIPLE_SITES_IN_LINE,
    PLACEMENT_IS_NOT_AVAILABLE_FOR_TARGETING_OR_EXCLUSION,
    INVALID_VERTICAL_PATH,
    YOUTUBE_VERTICAL_CHANNEL_DEPRECATED,
    YOUTUBE_DEMOGRAPHIC_CHANNEL_DEPRECATED,
    CANNOT_EXCLUDE_CRITERIA_TYPE,
    CANNOT_ADD_CRITERIA_TYPE,
    INVALID_PRODUCT_FILTER,
    PRODUCT_FILTER_TOO_LONG,
    CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SEARCH_ONLY_CAMPAIGNS,
    INVALID_CRITERION_ID,
    CANNOT_TARGET_CRITERION,
    CRITERION_ID_AND_TYPE_MISMATCH,
    INVALID_PROXIMITY_RADIUS,
    INVALID_PROXIMITY_RADIUS_UNITS,
    INVALID_STREETADDRESS_LENGTH,
    INVALID_CITYNAME_LENGTH,
    INVALID_REGIONCODE_LENGTH,
    INVALID_REGIONNAME_LENGTH,
    INVALID_POSTALCODE_LENGTH,
    INVALID_COUNTRY_CODE,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    PROXIMITY_GEOPOINT_AND_ADDRESS_BOTH_CANNOT_BE_NULL,
    INVALID_PROXIMITY_ADDRESS,
    AD_SCHEDULE_TIME_INTERVALS_OVERLAP,
    AD_SCHEDULE_INTERVAL_CANNOT_SPAN_MULTIPLE_DAYS,
    AD_SCHEDULE_INVALID_TIME_INTERVAL,
    AD_SCHEDULE_EXCEEDED_INTERVALS_PER_DAY_LIMIT,
    AD_SCHEDULE_CRITERION_ID_MISMATCHING_FIELDS,
    CANNOT_BID_MODIFY_CRITERION_TYPE,
    CANNOT_BID_MODIFY_CRITERION_CAMPAIGN_OPTED_OUT,
    CANNOT_BID_MODIFY_NEGATIVE_CRITERION,
    BID_MODIFIER_ALREADY_EXISTS,
    ACCOUNT_INELIGIBLE_FOR_CRITERIA_TYPE,
    CRITERIA_TYPE_INVALID_FOR_BIDDING_STRATEGY,
    CANNOT_EXCLUDE_CRITERION,
    CANNOT_REMOVE_CRITERION,
    PRODUCT_SCOPE_TOO_LONG,
    PRODUCT_SCOPE_TOO_MANY_DIMENSIONS,
    PRODUCT_PARTITION_TOO_LONG,
    PRODUCT_PARTITION_TOO_MANY_DIMENSIONS,
    INVALID_PRODUCT_DIMENSION,
    INVALID_PRODUCT_DIMENSION_TYPE,
    INVALID_PRODUCT_BIDDING_CATEGORY,
    MISSING_SHOPPING_SETTING,
    INVALID_MATCHING_FUNCTION,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignCriterionError : ApiError {
    private CampaignCriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignCriterionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignCriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignCriterionErrorReason {
    CONCRETE_TYPE_REQUIRED,
    INVALID_PLACEMENT_URL,
    CANNOT_EXCLUDE_CRITERIA_TYPE,
    CANNOT_TARGET_AND_EXCLUDE,
    TOO_MANY_OPERTAIONS,
    OPERATOR_NOT_SUPPORTED_FOR_CRITERION_TYPE,
    SHOPPING_CAMPAIGN_SALES_COUNTRY_NOT_SUPPORTED_FOR_SALES_CHANNEL,
    UNKNOWN,
    CANNOT_ADD_EXISTING_FIELD
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignCriterionOperation : Operation {
    private CampaignCriterion operandField;

    public CampaignCriterion operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignCriterionPage : Page {
    private CampaignCriterion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignCriterion[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignService : AdWordsSoapClient, ICampaignService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/CampaignService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((CampaignPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((CampaignReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignLabelReturnValue mutateLabel([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignLabelOperation[] operations) {
      object[] results = this.Invoke("mutateLabel", new object[] { operations });
      return ((CampaignLabelReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((CampaignPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignReturnValue : ListReturnValue {
    private Campaign[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Campaign[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Campaign {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private CampaignStatus statusField;

    private bool statusFieldSpecified;

    private ServingStatus servingStatusField;

    private bool servingStatusFieldSpecified;

    private string startDateField;

    private string endDateField;

    private Budget budgetField;

    private ConversionOptimizerEligibility conversionOptimizerEligibilityField;

    private AdServingOptimizationStatus adServingOptimizationStatusField;

    private bool adServingOptimizationStatusFieldSpecified;

    private FrequencyCap frequencyCapField;

    private Setting[] settingsField;

    private AdvertisingChannelType advertisingChannelTypeField;

    private bool advertisingChannelTypeFieldSpecified;

    private AdvertisingChannelSubType advertisingChannelSubTypeField;

    private bool advertisingChannelSubTypeFieldSpecified;

    private NetworkSetting networkSettingField;

    private Label[] labelsField;

    private BiddingStrategyConfiguration biddingStrategyConfigurationField;

    private String_StringMapEntry[] forwardCompatibilityMapField;

    private string trackingUrlTemplateField;

    private CustomParameters urlCustomParametersField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public CampaignStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public ServingStatus servingStatus {
      get { return this.servingStatusField; }
      set {
        this.servingStatusField = value;
        this.servingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool servingStatusSpecified {
      get { return this.servingStatusFieldSpecified; }
      set { this.servingStatusFieldSpecified = value; }
    }

    public string startDate {
      get { return this.startDateField; }
      set { this.startDateField = value; }
    }

    public string endDate {
      get { return this.endDateField; }
      set { this.endDateField = value; }
    }

    public Budget budget {
      get { return this.budgetField; }
      set { this.budgetField = value; }
    }

    public ConversionOptimizerEligibility conversionOptimizerEligibility {
      get { return this.conversionOptimizerEligibilityField; }
      set { this.conversionOptimizerEligibilityField = value; }
    }

    public AdServingOptimizationStatus adServingOptimizationStatus {
      get { return this.adServingOptimizationStatusField; }
      set {
        this.adServingOptimizationStatusField = value;
        this.adServingOptimizationStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adServingOptimizationStatusSpecified {
      get { return this.adServingOptimizationStatusFieldSpecified; }
      set { this.adServingOptimizationStatusFieldSpecified = value; }
    }

    public FrequencyCap frequencyCap {
      get { return this.frequencyCapField; }
      set { this.frequencyCapField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("settings")]
    public Setting[] settings {
      get { return this.settingsField; }
      set { this.settingsField = value; }
    }

    public AdvertisingChannelType advertisingChannelType {
      get { return this.advertisingChannelTypeField; }
      set {
        this.advertisingChannelTypeField = value;
        this.advertisingChannelTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool advertisingChannelTypeSpecified {
      get { return this.advertisingChannelTypeFieldSpecified; }
      set { this.advertisingChannelTypeFieldSpecified = value; }
    }

    public AdvertisingChannelSubType advertisingChannelSubType {
      get { return this.advertisingChannelSubTypeField; }
      set {
        this.advertisingChannelSubTypeField = value;
        this.advertisingChannelSubTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool advertisingChannelSubTypeSpecified {
      get { return this.advertisingChannelSubTypeFieldSpecified; }
      set { this.advertisingChannelSubTypeFieldSpecified = value; }
    }

    public NetworkSetting networkSetting {
      get { return this.networkSettingField; }
      set { this.networkSettingField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("labels")]
    public Label[] labels {
      get { return this.labelsField; }
      set { this.labelsField = value; }
    }

    public BiddingStrategyConfiguration biddingStrategyConfiguration {
      get { return this.biddingStrategyConfigurationField; }
      set { this.biddingStrategyConfigurationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("forwardCompatibilityMap")]
    public String_StringMapEntry[] forwardCompatibilityMap {
      get { return this.forwardCompatibilityMapField; }
      set { this.forwardCompatibilityMapField = value; }
    }

    public string trackingUrlTemplate {
      get { return this.trackingUrlTemplateField; }
      set { this.trackingUrlTemplateField = value; }
    }

    public CustomParameters urlCustomParameters {
      get { return this.urlCustomParametersField; }
      set { this.urlCustomParametersField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignStatus {
    UNKNOWN,
    ENABLED,
    PAUSED,
    REMOVED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ServingStatus {
    SERVING,
    NONE,
    ENDED,
    PENDING,
    SUSPENDED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Budget {
    private long budgetIdField;

    private bool budgetIdFieldSpecified;

    private string nameField;

    private BudgetBudgetPeriod periodField;

    private bool periodFieldSpecified;

    private Money amountField;

    private BudgetBudgetDeliveryMethod deliveryMethodField;

    private bool deliveryMethodFieldSpecified;

    private int referenceCountField;

    private bool referenceCountFieldSpecified;

    private bool isExplicitlySharedField;

    private bool isExplicitlySharedFieldSpecified;

    private BudgetBudgetStatus statusField;

    private bool statusFieldSpecified;

    public long budgetId {
      get { return this.budgetIdField; }
      set {
        this.budgetIdField = value;
        this.budgetIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool budgetIdSpecified {
      get { return this.budgetIdFieldSpecified; }
      set { this.budgetIdFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public BudgetBudgetPeriod period {
      get { return this.periodField; }
      set {
        this.periodField = value;
        this.periodSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool periodSpecified {
      get { return this.periodFieldSpecified; }
      set { this.periodFieldSpecified = value; }
    }

    public Money amount {
      get { return this.amountField; }
      set { this.amountField = value; }
    }

    public BudgetBudgetDeliveryMethod deliveryMethod {
      get { return this.deliveryMethodField; }
      set {
        this.deliveryMethodField = value;
        this.deliveryMethodSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deliveryMethodSpecified {
      get { return this.deliveryMethodFieldSpecified; }
      set { this.deliveryMethodFieldSpecified = value; }
    }

    public int referenceCount {
      get { return this.referenceCountField; }
      set {
        this.referenceCountField = value;
        this.referenceCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool referenceCountSpecified {
      get { return this.referenceCountFieldSpecified; }
      set { this.referenceCountFieldSpecified = value; }
    }

    public bool isExplicitlyShared {
      get { return this.isExplicitlySharedField; }
      set {
        this.isExplicitlySharedField = value;
        this.isExplicitlySharedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isExplicitlySharedSpecified {
      get { return this.isExplicitlySharedFieldSpecified; }
      set { this.isExplicitlySharedFieldSpecified = value; }
    }

    public BudgetBudgetStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Budget.BudgetPeriod", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BudgetBudgetPeriod {
    DAILY
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Money : ComparableValue {
    private long microAmountField;

    private bool microAmountFieldSpecified;

    public long microAmount {
      get { return this.microAmountField; }
      set {
        this.microAmountField = value;
        this.microAmountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool microAmountSpecified {
      get { return this.microAmountFieldSpecified; }
      set { this.microAmountFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NumberValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Money))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class ComparableValue {
    private string comparableValueTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ComparableValue.Type")]
    public string ComparableValueType {
      get { return this.comparableValueTypeField; }
      set { this.comparableValueTypeField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleValue))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class NumberValue : ComparableValue {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LongValue : NumberValue {
    private long numberField;

    private bool numberFieldSpecified;

    public long number {
      get { return this.numberField; }
      set {
        this.numberField = value;
        this.numberSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberSpecified {
      get { return this.numberFieldSpecified; }
      set { this.numberFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DoubleValue : NumberValue {
    private double numberField;

    private bool numberFieldSpecified;

    public double number {
      get { return this.numberField; }
      set {
        this.numberField = value;
        this.numberSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numberSpecified {
      get { return this.numberFieldSpecified; }
      set { this.numberFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Budget.BudgetDeliveryMethod", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BudgetBudgetDeliveryMethod {
    STANDARD,
    ACCELERATED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Budget.BudgetStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BudgetBudgetStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConversionOptimizerEligibility {
    private bool eligibleField;

    private bool eligibleFieldSpecified;

    private ConversionOptimizerEligibilityRejectionReason[] rejectionReasonsField;

    public bool eligible {
      get { return this.eligibleField; }
      set {
        this.eligibleField = value;
        this.eligibleSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool eligibleSpecified {
      get { return this.eligibleFieldSpecified; }
      set { this.eligibleFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("rejectionReasons")]
    public ConversionOptimizerEligibilityRejectionReason[] rejectionReasons {
      get { return this.rejectionReasonsField; }
      set { this.rejectionReasonsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionOptimizerEligibility.RejectionReason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConversionOptimizerEligibilityRejectionReason {
    CAMPAIGN_IS_NOT_ACTIVE,
    NOT_CPC_CAMPAIGN,
    CONVERSION_TRACKING_NOT_ENABLED,
    NOT_ENOUGH_CONVERSIONS,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdServingOptimizationStatus {
    OPTIMIZE,
    CONVERSION_OPTIMIZE,
    ROTATE,
    ROTATE_INDEFINITELY,
    UNAVAILABLE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FrequencyCap {
    private long impressionsField;

    private bool impressionsFieldSpecified;

    private TimeUnit timeUnitField;

    private bool timeUnitFieldSpecified;

    private Level levelField;

    private bool levelFieldSpecified;

    public long impressions {
      get { return this.impressionsField; }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get { return this.impressionsFieldSpecified; }
      set { this.impressionsFieldSpecified = value; }
    }

    public TimeUnit timeUnit {
      get { return this.timeUnitField; }
      set {
        this.timeUnitField = value;
        this.timeUnitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool timeUnitSpecified {
      get { return this.timeUnitFieldSpecified; }
      set { this.timeUnitFieldSpecified = value; }
    }

    public Level level {
      get { return this.levelField; }
      set {
        this.levelField = value;
        this.levelSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool levelSpecified {
      get { return this.levelFieldSpecified; }
      set { this.levelFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum TimeUnit {
    MINUTE,
    HOUR,
    DAY,
    WEEK,
    MONTH,
    LIFETIME
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum Level {
    CREATIVE,
    ADGROUP,
    CAMPAIGN,
    UNKNOWN
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TrackingSetting))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ShoppingSetting))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RealTimeBiddingSetting))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(GeoTargetTypeSetting))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicSearchAdsSetting))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetingSetting))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExplorerAutoOptimizerSetting))]
  public abstract partial class Setting {
    private string settingTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Setting.Type")]
    public string SettingType {
      get { return this.settingTypeField; }
      set { this.settingTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TrackingSetting : Setting {
    private string trackingUrlField;

    public string trackingUrl {
      get { return this.trackingUrlField; }
      set { this.trackingUrlField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ShoppingSetting : Setting {
    private long merchantIdField;

    private bool merchantIdFieldSpecified;

    private string salesCountryField;

    private int campaignPriorityField;

    private bool campaignPriorityFieldSpecified;

    public long merchantId {
      get { return this.merchantIdField; }
      set {
        this.merchantIdField = value;
        this.merchantIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool merchantIdSpecified {
      get { return this.merchantIdFieldSpecified; }
      set { this.merchantIdFieldSpecified = value; }
    }

    public string salesCountry {
      get { return this.salesCountryField; }
      set { this.salesCountryField = value; }
    }

    public int campaignPriority {
      get { return this.campaignPriorityField; }
      set {
        this.campaignPriorityField = value;
        this.campaignPrioritySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignPrioritySpecified {
      get { return this.campaignPriorityFieldSpecified; }
      set { this.campaignPriorityFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RealTimeBiddingSetting : Setting {
    private bool optInField;

    private bool optInFieldSpecified;

    public bool optIn {
      get { return this.optInField; }
      set {
        this.optInField = value;
        this.optInSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool optInSpecified {
      get { return this.optInFieldSpecified; }
      set { this.optInFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class GeoTargetTypeSetting : Setting {
    private GeoTargetTypeSettingPositiveGeoTargetType positiveGeoTargetTypeField;

    private bool positiveGeoTargetTypeFieldSpecified;

    private GeoTargetTypeSettingNegativeGeoTargetType negativeGeoTargetTypeField;

    private bool negativeGeoTargetTypeFieldSpecified;

    public GeoTargetTypeSettingPositiveGeoTargetType positiveGeoTargetType {
      get { return this.positiveGeoTargetTypeField; }
      set {
        this.positiveGeoTargetTypeField = value;
        this.positiveGeoTargetTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool positiveGeoTargetTypeSpecified {
      get { return this.positiveGeoTargetTypeFieldSpecified; }
      set { this.positiveGeoTargetTypeFieldSpecified = value; }
    }

    public GeoTargetTypeSettingNegativeGeoTargetType negativeGeoTargetType {
      get { return this.negativeGeoTargetTypeField; }
      set {
        this.negativeGeoTargetTypeField = value;
        this.negativeGeoTargetTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool negativeGeoTargetTypeSpecified {
      get { return this.negativeGeoTargetTypeFieldSpecified; }
      set { this.negativeGeoTargetTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeoTargetTypeSetting.PositiveGeoTargetType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum GeoTargetTypeSettingPositiveGeoTargetType {
    DONT_CARE,
    AREA_OF_INTEREST,
    LOCATION_OF_PRESENCE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeoTargetTypeSetting.NegativeGeoTargetType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum GeoTargetTypeSettingNegativeGeoTargetType {
    DONT_CARE,
    LOCATION_OF_PRESENCE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DynamicSearchAdsSetting : Setting {
    private string domainNameField;

    private string languageCodeField;

    public string domainName {
      get { return this.domainNameField; }
      set { this.domainNameField = value; }
    }

    public string languageCode {
      get { return this.languageCodeField; }
      set { this.languageCodeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdvertisingChannelType {
    UNKNOWN,
    SEARCH,
    DISPLAY,
    SHOPPING
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdvertisingChannelSubType {
    UNKNOWN,
    SEARCH_MOBILE_APP,
    DISPLAY_MOBILE_APP,
    SEARCH_EXPRESS,
    DISPLAY_EXPRESS
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class NetworkSetting {
    private bool targetGoogleSearchField;

    private bool targetGoogleSearchFieldSpecified;

    private bool targetSearchNetworkField;

    private bool targetSearchNetworkFieldSpecified;

    private bool targetContentNetworkField;

    private bool targetContentNetworkFieldSpecified;

    private bool targetPartnerSearchNetworkField;

    private bool targetPartnerSearchNetworkFieldSpecified;

    public bool targetGoogleSearch {
      get { return this.targetGoogleSearchField; }
      set {
        this.targetGoogleSearchField = value;
        this.targetGoogleSearchSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetGoogleSearchSpecified {
      get { return this.targetGoogleSearchFieldSpecified; }
      set { this.targetGoogleSearchFieldSpecified = value; }
    }

    public bool targetSearchNetwork {
      get { return this.targetSearchNetworkField; }
      set {
        this.targetSearchNetworkField = value;
        this.targetSearchNetworkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetSearchNetworkSpecified {
      get { return this.targetSearchNetworkFieldSpecified; }
      set { this.targetSearchNetworkFieldSpecified = value; }
    }

    public bool targetContentNetwork {
      get { return this.targetContentNetworkField; }
      set {
        this.targetContentNetworkField = value;
        this.targetContentNetworkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetContentNetworkSpecified {
      get { return this.targetContentNetworkFieldSpecified; }
      set { this.targetContentNetworkFieldSpecified = value; }
    }

    public bool targetPartnerSearchNetwork {
      get { return this.targetPartnerSearchNetworkField; }
      set {
        this.targetPartnerSearchNetworkField = value;
        this.targetPartnerSearchNetworkSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetPartnerSearchNetworkSpecified {
      get { return this.targetPartnerSearchNetworkFieldSpecified; }
      set { this.targetPartnerSearchNetworkFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextLabel))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Label {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private LabelStatus statusField;

    private bool statusFieldSpecified;

    private string labelTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public LabelStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Label.Type")]
    public string LabelType {
      get { return this.labelTypeField; }
      set { this.labelTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Label.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum LabelStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TextLabel : Label {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddingStrategyConfiguration {
    private long biddingStrategyIdField;

    private bool biddingStrategyIdFieldSpecified;

    private string biddingStrategyNameField;

    private BiddingStrategyType biddingStrategyTypeField;

    private bool biddingStrategyTypeFieldSpecified;

    private BiddingStrategySource biddingStrategySourceField;

    private bool biddingStrategySourceFieldSpecified;

    private BiddingScheme biddingSchemeField;

    private Bids[] bidsField;

    public long biddingStrategyId {
      get { return this.biddingStrategyIdField; }
      set {
        this.biddingStrategyIdField = value;
        this.biddingStrategyIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool biddingStrategyIdSpecified {
      get { return this.biddingStrategyIdFieldSpecified; }
      set { this.biddingStrategyIdFieldSpecified = value; }
    }

    public string biddingStrategyName {
      get { return this.biddingStrategyNameField; }
      set { this.biddingStrategyNameField = value; }
    }

    public BiddingStrategyType biddingStrategyType {
      get { return this.biddingStrategyTypeField; }
      set {
        this.biddingStrategyTypeField = value;
        this.biddingStrategyTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool biddingStrategyTypeSpecified {
      get { return this.biddingStrategyTypeFieldSpecified; }
      set { this.biddingStrategyTypeFieldSpecified = value; }
    }

    public BiddingStrategySource biddingStrategySource {
      get { return this.biddingStrategySourceField; }
      set {
        this.biddingStrategySourceField = value;
        this.biddingStrategySourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool biddingStrategySourceSpecified {
      get { return this.biddingStrategySourceFieldSpecified; }
      set { this.biddingStrategySourceFieldSpecified = value; }
    }

    public BiddingScheme biddingScheme {
      get { return this.biddingSchemeField; }
      set { this.biddingSchemeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("bids")]
    public Bids[] bids {
      get { return this.bidsField; }
      set { this.bidsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BiddingStrategyType {
    BUDGET_OPTIMIZER,
    CONVERSION_OPTIMIZER,
    MANUAL_CPC,
    MANUAL_CPM,
    PAGE_ONE_PROMOTED,
    TARGET_SPEND,
    ENHANCED_CPC,
    TARGET_CPA,
    TARGET_ROAS,
    NONE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BiddingStrategySource {
    CAMPAIGN,
    ADGROUP,
    CRITERION
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetSpendBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetRoasBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetCpaBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PageOnePromotedBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCpmBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCpcBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnhancedCpcBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionOptimizerBiddingScheme))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BudgetOptimizerBiddingScheme))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class BiddingScheme {
    private string biddingSchemeTypeField;

    [System.Xml.Serialization.XmlElementAttribute("BiddingScheme.Type")]
    public string BiddingSchemeType {
      get { return this.biddingSchemeTypeField; }
      set { this.biddingSchemeTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TargetSpendBiddingScheme : BiddingScheme {
    private Money bidCeilingField;

    private Money spendTargetField;

    public Money bidCeiling {
      get { return this.bidCeilingField; }
      set { this.bidCeilingField = value; }
    }

    public Money spendTarget {
      get { return this.spendTargetField; }
      set { this.spendTargetField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TargetRoasBiddingScheme : BiddingScheme {
    private double targetRoasField;

    private bool targetRoasFieldSpecified;

    private Money bidCeilingField;

    private Money bidFloorField;

    public double targetRoas {
      get { return this.targetRoasField; }
      set {
        this.targetRoasField = value;
        this.targetRoasSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetRoasSpecified {
      get { return this.targetRoasFieldSpecified; }
      set { this.targetRoasFieldSpecified = value; }
    }

    public Money bidCeiling {
      get { return this.bidCeilingField; }
      set { this.bidCeilingField = value; }
    }

    public Money bidFloor {
      get { return this.bidFloorField; }
      set { this.bidFloorField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TargetCpaBiddingScheme : BiddingScheme {
    private Money targetCpaField;

    private Money maxCpcBidCeilingField;

    private Money maxCpcBidFloorField;

    public Money targetCpa {
      get { return this.targetCpaField; }
      set { this.targetCpaField = value; }
    }

    public Money maxCpcBidCeiling {
      get { return this.maxCpcBidCeilingField; }
      set { this.maxCpcBidCeilingField = value; }
    }

    public Money maxCpcBidFloor {
      get { return this.maxCpcBidFloorField; }
      set { this.maxCpcBidFloorField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class PageOnePromotedBiddingScheme : BiddingScheme {
    private PageOnePromotedBiddingSchemeStrategyGoal strategyGoalField;

    private bool strategyGoalFieldSpecified;

    private Money bidCeilingField;

    private double bidModifierField;

    private bool bidModifierFieldSpecified;

    private bool bidChangesForRaisesOnlyField;

    private bool bidChangesForRaisesOnlyFieldSpecified;

    private bool raiseBidWhenBudgetConstrainedField;

    private bool raiseBidWhenBudgetConstrainedFieldSpecified;

    private bool raiseBidWhenLowQualityScoreField;

    private bool raiseBidWhenLowQualityScoreFieldSpecified;

    public PageOnePromotedBiddingSchemeStrategyGoal strategyGoal {
      get { return this.strategyGoalField; }
      set {
        this.strategyGoalField = value;
        this.strategyGoalSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool strategyGoalSpecified {
      get { return this.strategyGoalFieldSpecified; }
      set { this.strategyGoalFieldSpecified = value; }
    }

    public Money bidCeiling {
      get { return this.bidCeilingField; }
      set { this.bidCeilingField = value; }
    }

    public double bidModifier {
      get { return this.bidModifierField; }
      set {
        this.bidModifierField = value;
        this.bidModifierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidModifierSpecified {
      get { return this.bidModifierFieldSpecified; }
      set { this.bidModifierFieldSpecified = value; }
    }

    public bool bidChangesForRaisesOnly {
      get { return this.bidChangesForRaisesOnlyField; }
      set {
        this.bidChangesForRaisesOnlyField = value;
        this.bidChangesForRaisesOnlySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidChangesForRaisesOnlySpecified {
      get { return this.bidChangesForRaisesOnlyFieldSpecified; }
      set { this.bidChangesForRaisesOnlyFieldSpecified = value; }
    }

    public bool raiseBidWhenBudgetConstrained {
      get { return this.raiseBidWhenBudgetConstrainedField; }
      set {
        this.raiseBidWhenBudgetConstrainedField = value;
        this.raiseBidWhenBudgetConstrainedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool raiseBidWhenBudgetConstrainedSpecified {
      get { return this.raiseBidWhenBudgetConstrainedFieldSpecified; }
      set { this.raiseBidWhenBudgetConstrainedFieldSpecified = value; }
    }

    public bool raiseBidWhenLowQualityScore {
      get { return this.raiseBidWhenLowQualityScoreField; }
      set {
        this.raiseBidWhenLowQualityScoreField = value;
        this.raiseBidWhenLowQualityScoreSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool raiseBidWhenLowQualityScoreSpecified {
      get { return this.raiseBidWhenLowQualityScoreFieldSpecified; }
      set { this.raiseBidWhenLowQualityScoreFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PageOnePromotedBiddingScheme.StrategyGoal", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum PageOnePromotedBiddingSchemeStrategyGoal {
    PAGE_ONE,
    PAGE_ONE_PROMOTED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ManualCpmBiddingScheme : BiddingScheme {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ManualCpcBiddingScheme : BiddingScheme {
    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class EnhancedCpcBiddingScheme : BiddingScheme {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConversionOptimizerBiddingScheme : BiddingScheme {
    private ConversionOptimizerBiddingSchemePricingMode pricingModeField;

    private bool pricingModeFieldSpecified;

    private ConversionOptimizerBiddingSchemeBidType bidTypeField;

    private bool bidTypeFieldSpecified;

    public ConversionOptimizerBiddingSchemePricingMode pricingMode {
      get { return this.pricingModeField; }
      set {
        this.pricingModeField = value;
        this.pricingModeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool pricingModeSpecified {
      get { return this.pricingModeFieldSpecified; }
      set { this.pricingModeFieldSpecified = value; }
    }

    public ConversionOptimizerBiddingSchemeBidType bidType {
      get { return this.bidTypeField; }
      set {
        this.bidTypeField = value;
        this.bidTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidTypeSpecified {
      get { return this.bidTypeFieldSpecified; }
      set { this.bidTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionOptimizerBiddingScheme.PricingMode", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConversionOptimizerBiddingSchemePricingMode {
    CLICKS,
    CONVERSIONS
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionOptimizerBiddingScheme.BidType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConversionOptimizerBiddingSchemeBidType {
    TARGET_CPA
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BudgetOptimizerBiddingScheme : BiddingScheme {
    private Money bidCeilingField;

    private bool enhancedCpcEnabledField;

    private bool enhancedCpcEnabledFieldSpecified;

    public Money bidCeiling {
      get { return this.bidCeilingField; }
      set { this.bidCeilingField = value; }
    }

    public bool enhancedCpcEnabled {
      get { return this.enhancedCpcEnabledField; }
      set {
        this.enhancedCpcEnabledField = value;
        this.enhancedCpcEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool enhancedCpcEnabledSpecified {
      get { return this.enhancedCpcEnabledFieldSpecified; }
      set { this.enhancedCpcEnabledFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CpmBid))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CpcBid))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CpaBid))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class Bids {
    private string bidsTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Bids.Type")]
    public string BidsType {
      get { return this.bidsTypeField; }
      set { this.bidsTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CpmBid : Bids {
    private Money bidField;

    private BidSource cpmBidSourceField;

    private bool cpmBidSourceFieldSpecified;

    public Money bid {
      get { return this.bidField; }
      set { this.bidField = value; }
    }

    public BidSource cpmBidSource {
      get { return this.cpmBidSourceField; }
      set {
        this.cpmBidSourceField = value;
        this.cpmBidSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool cpmBidSourceSpecified {
      get { return this.cpmBidSourceFieldSpecified; }
      set { this.cpmBidSourceFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BidSource {
    ADGROUP,
    CRITERION
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CpcBid : Bids {
    private Money bidField;

    private BidSource cpcBidSourceField;

    private bool cpcBidSourceFieldSpecified;

    public Money bid {
      get { return this.bidField; }
      set { this.bidField = value; }
    }

    public BidSource cpcBidSource {
      get { return this.cpcBidSourceField; }
      set {
        this.cpcBidSourceField = value;
        this.cpcBidSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool cpcBidSourceSpecified {
      get { return this.cpcBidSourceFieldSpecified; }
      set { this.cpcBidSourceFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CpaBid : Bids {
    private Money bidField;

    public Money bid {
      get { return this.bidField; }
      set { this.bidField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CustomParameters {
    private CustomParameter[] parametersField;

    private bool doReplaceField;

    private bool doReplaceFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("parameters")]
    public CustomParameter[] parameters {
      get { return this.parametersField; }
      set { this.parametersField = value; }
    }

    public bool doReplace {
      get { return this.doReplaceField; }
      set {
        this.doReplaceField = value;
        this.doReplaceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool doReplaceSpecified {
      get { return this.doReplaceFieldSpecified; }
      set { this.doReplaceFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CustomParameter {
    private string keyField;

    private string valueField;

    private bool isRemoveField;

    private bool isRemoveFieldSpecified;

    public string key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    public bool isRemove {
      get { return this.isRemoveField; }
      set {
        this.isRemoveField = value;
        this.isRemoveSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isRemoveSpecified {
      get { return this.isRemoveFieldSpecified; }
      set { this.isRemoveFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class UrlError : ApiError {
    private UrlErrorReason reasonField;

    private bool reasonFieldSpecified;

    public UrlErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UrlError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum UrlErrorReason {
    INVALID_URL,
    INVALID_TAG_IN_URL,
    MISSING_URL_TAG,
    INVALID_TRACKING_URL_TEMPLATE,
    INVALID_TAG_IN_TRACKING_URL_TEMPLATE,
    MISSING_TRACKING_URL_TEMPLATE_TAG,
    INVALID_FINAL_URL,
    INVALID_TAG_IN_FINAL_URL,
    INVALID_FINAL_MOBILE_URL,
    INVALID_FINAL_APP_URL,
    INVALID_TAG_IN_FINAL_MOBILE_URL,
    INVALID_TAG_IN_FINAL_APP_URL,
    URL_CUSTOM_PARAMETERS_COUNT_EXCEEDS_LIMIT,
    URL_CUSTOM_PARAMETER_REMOVAL_WITH_NON_NULL_VALUE,
    CANNOT_REMOVE_URL_CUSTOM_PARAMETER_IN_ADD_OPERATION,
    INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_KEY,
    INVALID_CHARACTERS_IN_URL_CUSTOM_PARAMETER_VALUE,
    INVALID_TAG_IN_URL_CUSTOM_PARAMETER_VALUE,
    MISSING_PROTOCOL,
    MULTIPLE_APP_URLS_FOR_OSTYPE,
    INVALID_OSTYPE,
    INVALID_PROTOCOL_FOR_APP_URL,
    INVALID_PACKAGE_ID_FOR_APP_URL,
    URL_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TargetError : ApiError {
    private TargetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TargetErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TargetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum TargetErrorReason {
    AD_SCHEDULE_ADVANCED_INCOMPATIBLE_WITH_CONVERSION_OPTIMIZER,
    AD_SCHEDULE_BID_MULTIPLIER_MALFORMED,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_BIG,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_SMALL,
    AD_SCHEDULE_BID_MULTIPLIER_TOO_MANY_FRACTION_DIGITS,
    AD_SCHEDULE_EXCEEDED_INTERVALS_PER_DAY_LIMIT,
    AD_SCHEDULE_EXCEEDS_PAST_END_OF_WEEK,
    AD_SCHEDULE_INCOMPATIBILITY,
    AD_SCHEDULE_INCOMPATIBLE_WITH_BUDGET_OPTIMIZER,
    AD_SCHEDULE_INTERVAL_CANNOT_SPAN_MULTIPLE_DAYS,
    AD_SCHEDULE_INVALID_DAY_OF_THE_WEEK,
    AD_SCHEDULE_INVALID_TIME_INTERVAL,
    AD_SCHEDULE_NO_INTERVALS_WHILE_ENABLED,
    AD_SCHEDULE_NOT_MULTIPLE_OF_15_MINUTES,
    AD_SCHEDULE_TIME_INTERVALS_OVERLAP,
    CANNOT_EXCLUDE_CITY,
    CANNOT_EXCLUDE_IF_NOT_TARGETED,
    CANNOT_EXCLUDE_METRO,
    CANNOT_EXCLUDE_PROVINCE,
    CANNOT_OPT_OUT_GOOGLE_SEARCH_WHILE_BID_TO_POSITION_ENABLE,
    CANNOT_TARGET_AGE_WITHOUT_GENDER,
    CANNOT_TARGET_CITY,
    CANNOT_TARGET_CONTENT_CONTEXTUAL_WITHOUT_CONTENT_NETWORK,
    CANNOT_MODIFY_CONTENT_CONTEXTUAL,
    CANNOT_TARGET_COUNTRY,
    CANNOT_TARGET_COVERAGE,
    CANNOT_TARGET_GENDER_WITHOUT_AGE,
    CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN,
    CANNOT_CHANGE_GOOGLE_SEARCH_SETTING,
    CANNOT_TARGET_LANGUAGE,
    CANNOT_TARGET_METRO,
    CANNOT_TARGET_MOBILE_CARRIER,
    CANNOT_TARGET_PROVINCE,
    CANNOT_TARGET_SEARCH_SYNDICATION_WITHOUT_GOOGLE_SEARCH,
    CANNOT_TARGET_SYNDICATABLE_TYPES,
    CANNOT_TARGET_THE_SAME_TARGET_LIST_TYPE_MULTIPLE_TIMES,
    DEMOGRAPHIC_BID_MODIFIER_SHOULD_BE_IN_BETWEEN_0_AND_500,
    INVALID_CITY_CODE,
    INVALID_CITYNAME_LENGTH,
    INVALID_EXCLUDED_POLYGON_TARGET,
    INVALID_EXCLUDED_PROXIMITY_TARGET,
    INVALID_LANGUAGE_CODE,
    INVALID_LATITUDE,
    INVALID_LONGITUDE,
    INVALID_METRO_CODE,
    INVALID_MOBILE_CARRIER,
    INVALID_MOBILE_PLATFORM,
    INVALID_POSTALCODE_LENGTH,
    INVALID_PROVINCE_CODE,
    INVALID_PROXIMITY_RADIUS,
    INVALID_REGIONCODE_LENGTH,
    INVALID_REGIONNAME_LENGTH,
    INVALID_STREETADDRESS_LENGTH,
    MULTIPLE_OCCURRENCES_OF_SAME_TARGET,
    POLYGON_DUPLICATE_VERTICES,
    POLYGON_EDGES_INTERSECT,
    POLYGON_TOO_FEW_VERTICES,
    POLYGON_TOO_MANY_VERTICES,
    POLYGON_TOO_LARGE,
    TARGETING_VALIDATION_FAILED,
    TARGETING_CROSS_COUNTRY_REGIONAL,
    TARGETING_EXCLUSION_NOT_SUPPORTED,
    TARGETING_INCOMPATIBLE_LOCATION_TYPES,
    TARGETING_NOT_SUPPORTED,
    TARGETING_TOO_MANY_REGIONS,
    TOO_MANY_EXCLUDED_LOCATIONS,
    TOO_MANY_TARGETED_LOCATIONS,
    WARNING_MAY_NOW_REQUIRE_CHINESE_APPROVAL,
    WARNING_NOW_REQUIRES_CHINESE_APPROVAL,
    WARNING_NOW_TARGETS_CHINA,
    WARNING_NOW_TARGETS_CHINESE,
    TARGET_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class StringFormatError : ApiError {
    private StringFormatErrorReason reasonField;

    private bool reasonFieldSpecified;

    public StringFormatErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringFormatError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum StringFormatErrorReason {
    UNKNOWN,
    ILLEGAL_CHARS,
    INVALID_FORMAT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class StatsQueryError : ApiError {
    private StatsQueryErrorReason reasonField;

    private bool reasonFieldSpecified;

    public StatsQueryErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StatsQueryError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum StatsQueryErrorReason {
    DATE_NOT_IN_VALID_RANGE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SettingError : ApiError {
    private SettingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SettingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SettingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SettingErrorReason {
    DUPLICATE_SETTING_TYPE,
    SETTING_TYPE_IS_NOT_AVAILABLE,
    SETTING_TYPE_IS_NOT_COMPATIBLE_WITH_CAMPAIGN,
    TARGETING_SETTING_CONTAINS_INVALID_CRITERION_TYPE_GROUP,
    DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_DOMAIN_NAME,
    DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_LANGUAGE_CODE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class QuotaError : ApiError {
    private QuotaErrorReason reasonField;

    private bool reasonFieldSpecified;

    private int limitField;

    private bool limitFieldSpecified;

    public QuotaErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public int limit {
      get { return this.limitField; }
      set {
        this.limitField = value;
        this.limitSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitSpecified {
      get { return this.limitFieldSpecified; }
      set { this.limitFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "QuotaError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum QuotaErrorReason {
    TOO_MANY_ADGROUPS_PER_CAMPAIGN,
    TOO_MANY_CAMPAIGNS_PER_ACCOUNT,
    TOO_MANY_CONVERSION_TYPES_PER_ACCOUNT,
    TOO_MANY_KEYWORDS_PER_ADGROUP,
    TOO_MANY_KEYWORDS_PER_CAMPAIGN,
    TOO_MANY_KEYWORDS_PER_CUSTOMER,
    TOO_MANY_SITES_PER_ADGROUP,
    TOO_MANY_SITES_PER_CAMPAIGN,
    TOO_MANY_CRITERIA_PER_ACCOUNT,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ForwardCompatibilityError : ApiError {
    private ForwardCompatibilityErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ForwardCompatibilityErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ForwardCompatibilityError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ForwardCompatibilityErrorReason {
    INVALID_FORWARD_COMPATIBILITY_MAP_VALUE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class EntityAccessDenied : ApiError {
    private EntityAccessDeniedReason reasonField;

    private bool reasonFieldSpecified;

    public EntityAccessDeniedReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "EntityAccessDenied.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum EntityAccessDeniedReason {
    READ_ACCESS_DENIED,
    WRITE_ACCESS_DENIED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DateRangeError : ApiError {
    private DateRangeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DateRangeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DateRangeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum DateRangeErrorReason {
    DATE_RANGE_ERROR,
    INVALID_DATE,
    START_DATE_AFTER_END_DATE,
    CANNOT_SET_DATE_TO_PAST,
    AFTER_MAXIMUM_ALLOWABLE_DATE,
    CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DateError : ApiError {
    private DateErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DateErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DateError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum DateErrorReason {
    INVALID_FIELD_VALUES_IN_DATE,
    INVALID_FIELD_VALUES_IN_DATE_TIME,
    INVALID_STRING_DATE,
    INVALID_STRING_DATE_RANGE,
    INVALID_STRING_DATE_TIME,
    EARLIER_THAN_MINIMUM_DATE,
    LATER_THAN_MAXIMUM_DATE,
    DATE_RANGE_MINIMUM_DATE_LATER_THAN_MAXIMUM_DATE,
    DATE_RANGE_MINIMUM_AND_MAXIMUM_DATES_BOTH_NULL
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignError : ApiError {
    private CampaignErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignErrorReason {
    CANNOT_GO_BACK_TO_INCOMPLETE,
    CANNOT_SET_END_DATE_BEFORE_EXPERIMENT_END_DATE,
    DUPLICATE_CAMPAIGN_NAME,
    INCOMPATIBLE_CAMPAIGN_FIELD,
    INVALID_CAMPAIGN_NAME,
    INVALID_AD_SERVING_OPTIMIZATION_STATUS,
    INVALID_TRACKING_URL,
    MAX_IMPRESSIONS_NOT_IN_RANGE,
    TIME_UNIT_NOT_SUPPORTED,
    INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED,
    BUDGET_CANNOT_BE_SHARED,
    CAMPAIGN_CANNOT_USE_SHARED_BUDGET,
    CAMPAIGN_LABEL_DOES_NOT_EXIST,
    CAMPAIGN_LABEL_ALREADY_EXISTS,
    MUST_SPECIFY_KEYWORD_MATCH_SETTINGS,
    MISSING_SHOPPING_SETTING,
    INVALID_SHOPPING_SALES_COUNTRY,
    ADVERTISING_CHANNEL_TYPE_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BudgetError : ApiError {
    private BudgetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BudgetErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BudgetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BudgetErrorReason {
    BUDGET_REMOVED,
    BUDGET_ERROR,
    BUDGET_IN_USE,
    BUDGET_PERIOD_NOT_AVAILABLE,
    CANNOT_EDIT_SHARED_BUDGET,
    CANNOT_MODIFY_FIELD_OF_IMPLICITLY_SHARED_BUDGET,
    CANNOT_UPDATE_BUDGET_TO_IMPLICITLY_SHARED,
    CANNOT_USE_IMPLICITLY_SHARED_BUDGET_WITH_MULTIPLE_CAMPAIGNS,
    DUPLICATE_NAME,
    MONEY_AMOUNT_IN_WRONG_CURRENCY,
    MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC,
    MONEY_AMOUNT_TOO_LARGE,
    NEGATIVE_MONEY_AMOUNT,
    NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddingErrors : ApiError {
    private BiddingErrorsReason reasonField;

    private bool reasonFieldSpecified;

    public BiddingErrorsReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingErrors.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BiddingErrorsReason {
    BIDDING_STRATEGY_TRANSITION_NOT_ALLOWED,
    BIDDING_STRATEGY_NOT_COMPATIBLE_WITH_ADGROUP_OVERRIDES,
    BIDDING_STRATEGY_NOT_COMPATIBLE_WITH_ADGROUP_CRITERIA_OVERRIDES,
    CAMPAIGN_BIDDING_STRATEGY_CANNOT_BE_OVERRIDDEN,
    ADGROUP_BIDDING_STRATEGY_CANNOT_BE_OVERRIDDEN,
    CANNOT_ATTACH_BIDDING_STRATEGY_TO_CAMPAIGN,
    CANNOT_ATTACH_BIDDING_STRATEGY_TO_ADGROUP,
    CANNOT_ATTACH_BIDDING_STRATEGY_TO_ADGROUP_CRITERIA,
    INVALID_ANONYMOUS_BIDDING_STRATEGY_TYPE,
    BIDS_NOT_ALLLOWED,
    DUPLICATE_BIDS,
    INVALID_BIDDING_SCHEME,
    INVALID_BIDDING_STRATEGY_TYPE,
    MISSING_BIDDING_STRATEGY_TYPE,
    NULL_BID,
    INVALID_BID,
    BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    CONVERSION_TRACKING_NOT_ENABLED,
    NOT_ENOUGH_CONVERSIONS,
    CANNOT_CREATE_CAMPAIGN_WITH_CONVERSION_OPTIMIZER,
    CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_AD_GROUP_LEVEL_POP_BIDDING_STRATEGY,
    CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CAMPAIGN_LEVEL_POP_BIDDING_STRATEGY,
    BIDDING_STRATEGY_NOT_SUPPORTED_WITH_AD_SCHEDULE,
    PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER,
    PAY_PER_CONVERSION_NOT_ALLOWED_WITH_TARGET_CPA,
    BIDDING_STRATEGY_NOT_ALLOWED_FOR_SEARCH_ONLY_CAMPAIGNS,
    BIDDING_STRATEGY_NOT_SUPPORTED_FOR_CAMPAIGNS_WITH_EXPERIMENTS,
    CANNOT_CHANGE_BIDDING_STRATEGY_IN_CAMPAIGN_WITH_EXPERIMENT,
    BIDDING_STRATEGY_TYPE_DOES_NOT_SUPPORT_PRODUCT_TYPE_ADGROUP_CRITERION,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddingError : ApiError {
    private BiddingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BiddingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BiddingErrorReason {
    BID_AMOUNT_REQUIRED,
    BID_TOO_SMALL,
    BID_TOO_BIG,
    BID_TOO_MANY_FRACTIONAL_DIGITS,
    NON_POSITIVE_BID,
    BID_TOO_HIGH_FOR_DAILY_BUDGET,
    BID_TOO_HIGH_FOR_MONTHLY_BUDGET,
    MUST_EXCLUDE_0_TO_17_WITH_OTHER_AGE_EXCLUSIONS,
    CAMPAIGN_MUST_HAVE_A_BUDGET_TO_ENABLE_BUDGET_OPTIMIZER,
    CANNOT_SET_CONTENT_BID_WITHOUT_SETTING_KEYWORD_MAX_CPC_AS_WELL,
    CANNOT_CREATE_CAMPAIGN_WITH_CONVERSION_OPTIMIZER,
    PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER,
    PAY_PER_CONVERSION_NOT_ALLOWED_WITH_TARGET_CPA,
    PAY_PER_CONVERSION_NOT_ALLOWED_WITH_MANY_PER_CLICK,
    TARGET_CPA_NOT_AVAILABLE_FOR_CUSTOMER,
    MANY_PER_CLICK_NOT_AVAILABLE_FOR_CUSTOMER,
    CANNOT_SET_SITE_MAX_CPC,
    BID_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignLabelReturnValue : ListReturnValue {
    private CampaignLabel[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignLabel[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignLabel {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long labelIdField;

    private bool labelIdFieldSpecified;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public long labelId {
      get { return this.labelIdField; }
      set {
        this.labelIdField = value;
        this.labelIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool labelIdSpecified {
      get { return this.labelIdFieldSpecified; }
      set { this.labelIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignOperation : Operation {
    private Campaign operandField;

    public Campaign operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignLabelOperation : Operation {
    private CampaignLabel operandField;

    public CampaignLabel operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignPage : Page {
    private Campaign[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Campaign[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignFeedServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignFeedService : AdWordsSoapClient, ICampaignFeedService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignFeedService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/CampaignFeedService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignFeedPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((CampaignFeedPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignFeedReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignFeedOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((CampaignFeedReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignFeedPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((CampaignFeedPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignFeedReturnValue : ListReturnValue {
    private CampaignFeed[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignFeed[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignFeed {
    private long feedIdField;

    private bool feedIdFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private Function matchingFunctionField;

    private int[] placeholderTypesField;

    private CampaignFeedStatus statusField;

    private bool statusFieldSpecified;

    public long feedId {
      get { return this.feedIdField; }
      set {
        this.feedIdField = value;
        this.feedIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedIdSpecified {
      get { return this.feedIdFieldSpecified; }
      set { this.feedIdFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public Function matchingFunction {
      get { return this.matchingFunctionField; }
      set { this.matchingFunctionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("placeholderTypes")]
    public int[] placeholderTypes {
      get { return this.placeholderTypesField; }
      set { this.placeholderTypesField = value; }
    }

    public CampaignFeedStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class RequestContextOperand : FunctionArgumentOperand {
    private RequestContextOperandContextType contextTypeField;

    private bool contextTypeFieldSpecified;

    public RequestContextOperandContextType contextType {
      get { return this.contextTypeField; }
      set {
        this.contextTypeField = value;
        this.contextTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool contextTypeSpecified {
      get { return this.contextTypeFieldSpecified; }
      set { this.contextTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RequestContextOperand.ContextType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RequestContextOperandContextType {
    FEED_ITEM_ID,
    DEVICE_PLATFORM,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FunctionOperand : FunctionArgumentOperand {
    private Function valueField;

    public Function value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedAttributeOperand : FunctionArgumentOperand {
    private long feedIdField;

    private bool feedIdFieldSpecified;

    private long feedAttributeIdField;

    private bool feedAttributeIdFieldSpecified;

    public long feedId {
      get { return this.feedIdField; }
      set {
        this.feedIdField = value;
        this.feedIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedIdSpecified {
      get { return this.feedIdFieldSpecified; }
      set { this.feedIdFieldSpecified = value; }
    }

    public long feedAttributeId {
      get { return this.feedAttributeIdField; }
      set {
        this.feedAttributeIdField = value;
        this.feedAttributeIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedAttributeIdSpecified {
      get { return this.feedAttributeIdFieldSpecified; }
      set { this.feedAttributeIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignFeed.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignFeedStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignFeedOperation : Operation {
    private CampaignFeed operandField;

    public CampaignFeed operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignFeedPage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CustomerFeedPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedItemPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(FeedMappingPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupFeedPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignSharedSetPage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SharedSetPage))]
  public abstract partial class NullStatsPage : Page {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignFeedPage : NullStatsPage {
    private CampaignFeed[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignFeed[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CollectionSizeError : ApiError {
    private CollectionSizeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CollectionSizeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CollectionSizeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CollectionSizeErrorReason {
    TOO_FEW,
    TOO_MANY
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignFeedError : ApiError {
    private CampaignFeedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignFeedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignFeedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignFeedErrorReason {
    FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE,
    INVALID_ID,
    CANNOT_ADD_ALREADY_EXISTING_CAMPAIGN_FEED,
    CANNOT_OPERATE_ON_REMOVED_CAMPAIGN_FEED,
    INVALID_PLACEHOLDER_TYPES,
    MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE,
    NO_EXISTING_LOCATION_CUSTOMER_FEED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ConstantDataServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductDimension))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConstantData))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Criterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ConstantDataService : AdWordsSoapClient, IConstantDataService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ConstantDataService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/ConstantDataService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AgeRange[] getAgeRangeCriterion() {
      object[] results = this.Invoke("getAgeRangeCriterion", new object[0]);
      return ((AgeRange[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Carrier[] getCarrierCriterion() {
      object[] results = this.Invoke("getCarrierCriterion", new object[0]);
      return ((Carrier[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Gender[] getGenderCriterion() {
      object[] results = this.Invoke("getGenderCriterion", new object[0]);
      return ((Gender[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Language[] getLanguageCriterion() {
      object[] results = this.Invoke("getLanguageCriterion", new object[0]);
      return ((Language[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual MobileDevice[] getMobileDeviceCriterion() {
      object[] results = this.Invoke("getMobileDeviceCriterion", new object[0]);
      return ((MobileDevice[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual OperatingSystemVersion[] getOperatingSystemVersionCriterion() {
      object[] results = this.Invoke("getOperatingSystemVersionCriterion", new object[0]);
      return ((OperatingSystemVersion[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ProductBiddingCategoryData[] getProductBiddingCategoryData(Selector selector) {
      object[] results = this.Invoke("getProductBiddingCategoryData", new object[] { selector });
      return ((ProductBiddingCategoryData[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CriterionUserInterest[] getUserInterestCriterion(ConstantDataServiceUserInterestTaxonomyType userInterestTaxonomyType) {
      object[] results = this.Invoke("getUserInterestCriterion", new object[] { userInterestTaxonomyType });
      return ((CriterionUserInterest[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Vertical[] getVerticalCriterion() {
      object[] results = this.Invoke("getVerticalCriterion", new object[0]);
      return ((Vertical[]) (results[0]));
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductBiddingCategoryData))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConstantData {
    private string constantDataTypeField;

    [System.Xml.Serialization.XmlElementAttribute("ConstantData.Type")]
    public string ConstantDataType {
      get { return this.constantDataTypeField; }
      set { this.constantDataTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductBiddingCategoryData : ConstantData {
    private ProductBiddingCategory dimensionValueField;

    private ProductBiddingCategory parentDimensionValueField;

    private string countryField;

    private ShoppingBiddingDimensionStatus statusField;

    private bool statusFieldSpecified;

    private String_StringMapEntry[] displayValueField;

    public ProductBiddingCategory dimensionValue {
      get { return this.dimensionValueField; }
      set { this.dimensionValueField = value; }
    }

    public ProductBiddingCategory parentDimensionValue {
      get { return this.parentDimensionValueField; }
      set { this.parentDimensionValueField = value; }
    }

    public string country {
      get { return this.countryField; }
      set { this.countryField = value; }
    }

    public ShoppingBiddingDimensionStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("displayValue")]
    public String_StringMapEntry[] displayValue {
      get { return this.displayValueField; }
      set { this.displayValueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ShoppingBiddingDimensionStatus {
    UNKNOWN,
    ACTIVE,
    OBSOLETE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConstantDataService.UserInterestTaxonomyType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConstantDataServiceUserInterestTaxonomyType {
    BRAND,
    IN_MARKET,
    MOBILE_APP_INSTALL_USER,
    VERTICAL_GEO
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ConversionTrackerServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ConversionTrackerService : AdWordsSoapClient, IConversionTrackerService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ConversionTrackerService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/ConversionTrackerService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ConversionTrackerPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((ConversionTrackerPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ConversionTrackerReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
ConversionTrackerOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((ConversionTrackerReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConversionTrackerReturnValue : ListReturnValue {
    private ConversionTracker[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public ConversionTracker[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebsiteCallMetricsConversion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(UploadConversion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AppConversion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdWordsConversionTracker))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdCallMetricsConversion))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class ConversionTracker {
    private long idField;

    private bool idFieldSpecified;

    private long originalConversionTypeIdField;

    private bool originalConversionTypeIdFieldSpecified;

    private string nameField;

    private ConversionTrackerStatus statusField;

    private bool statusFieldSpecified;

    private ConversionTrackerCategory categoryField;

    private bool categoryFieldSpecified;

    private ConversionTrackerStats statsField;

    private int viewthroughLookbackWindowField;

    private bool viewthroughLookbackWindowFieldSpecified;

    private bool isProductAdsChargeableField;

    private bool isProductAdsChargeableFieldSpecified;

    private int productAdsChargeableConversionWindowField;

    private bool productAdsChargeableConversionWindowFieldSpecified;

    private int ctcLookbackWindowField;

    private bool ctcLookbackWindowFieldSpecified;

    private ConversionDeduplicationMode countingTypeField;

    private bool countingTypeFieldSpecified;

    private double defaultRevenueValueField;

    private bool defaultRevenueValueFieldSpecified;

    private string defaultRevenueCurrencyCodeField;

    private bool alwaysUseDefaultRevenueValueField;

    private bool alwaysUseDefaultRevenueValueFieldSpecified;

    private bool excludeFromBiddingField;

    private bool excludeFromBiddingFieldSpecified;

    private string conversionTrackerTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public long originalConversionTypeId {
      get { return this.originalConversionTypeIdField; }
      set {
        this.originalConversionTypeIdField = value;
        this.originalConversionTypeIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool originalConversionTypeIdSpecified {
      get { return this.originalConversionTypeIdFieldSpecified; }
      set { this.originalConversionTypeIdFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public ConversionTrackerStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public ConversionTrackerCategory category {
      get { return this.categoryField; }
      set {
        this.categoryField = value;
        this.categorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categorySpecified {
      get { return this.categoryFieldSpecified; }
      set { this.categoryFieldSpecified = value; }
    }

    public ConversionTrackerStats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }

    public int viewthroughLookbackWindow {
      get { return this.viewthroughLookbackWindowField; }
      set {
        this.viewthroughLookbackWindowField = value;
        this.viewthroughLookbackWindowSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool viewthroughLookbackWindowSpecified {
      get { return this.viewthroughLookbackWindowFieldSpecified; }
      set { this.viewthroughLookbackWindowFieldSpecified = value; }
    }

    public bool isProductAdsChargeable {
      get { return this.isProductAdsChargeableField; }
      set {
        this.isProductAdsChargeableField = value;
        this.isProductAdsChargeableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isProductAdsChargeableSpecified {
      get { return this.isProductAdsChargeableFieldSpecified; }
      set { this.isProductAdsChargeableFieldSpecified = value; }
    }

    public int productAdsChargeableConversionWindow {
      get { return this.productAdsChargeableConversionWindowField; }
      set {
        this.productAdsChargeableConversionWindowField = value;
        this.productAdsChargeableConversionWindowSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool productAdsChargeableConversionWindowSpecified {
      get { return this.productAdsChargeableConversionWindowFieldSpecified; }
      set { this.productAdsChargeableConversionWindowFieldSpecified = value; }
    }

    public int ctcLookbackWindow {
      get { return this.ctcLookbackWindowField; }
      set {
        this.ctcLookbackWindowField = value;
        this.ctcLookbackWindowSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ctcLookbackWindowSpecified {
      get { return this.ctcLookbackWindowFieldSpecified; }
      set { this.ctcLookbackWindowFieldSpecified = value; }
    }

    public ConversionDeduplicationMode countingType {
      get { return this.countingTypeField; }
      set {
        this.countingTypeField = value;
        this.countingTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool countingTypeSpecified {
      get { return this.countingTypeFieldSpecified; }
      set { this.countingTypeFieldSpecified = value; }
    }

    public double defaultRevenueValue {
      get { return this.defaultRevenueValueField; }
      set {
        this.defaultRevenueValueField = value;
        this.defaultRevenueValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool defaultRevenueValueSpecified {
      get { return this.defaultRevenueValueFieldSpecified; }
      set { this.defaultRevenueValueFieldSpecified = value; }
    }

    public string defaultRevenueCurrencyCode {
      get { return this.defaultRevenueCurrencyCodeField; }
      set { this.defaultRevenueCurrencyCodeField = value; }
    }

    public bool alwaysUseDefaultRevenueValue {
      get { return this.alwaysUseDefaultRevenueValueField; }
      set {
        this.alwaysUseDefaultRevenueValueField = value;
        this.alwaysUseDefaultRevenueValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool alwaysUseDefaultRevenueValueSpecified {
      get { return this.alwaysUseDefaultRevenueValueFieldSpecified; }
      set { this.alwaysUseDefaultRevenueValueFieldSpecified = value; }
    }

    public bool excludeFromBidding {
      get { return this.excludeFromBiddingField; }
      set {
        this.excludeFromBiddingField = value;
        this.excludeFromBiddingSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool excludeFromBiddingSpecified {
      get { return this.excludeFromBiddingFieldSpecified; }
      set { this.excludeFromBiddingFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ConversionTracker.Type")]
    public string ConversionTrackerType {
      get { return this.conversionTrackerTypeField; }
      set { this.conversionTrackerTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionTracker.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConversionTrackerStatus {
    ENABLED,
    DISABLED,
    HIDDEN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionTracker.Category", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConversionTrackerCategory {
    DEFAULT,
    PAGE_VIEW,
    PURCHASE,
    SIGNUP,
    LEAD,
    REMARKETING,
    DOWNLOAD
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConversionTrackerStats {
    private int numConversionEventsField;

    private bool numConversionEventsFieldSpecified;

    private Money conversionValueField;

    private string mostRecentConversionDateField;

    private int numConvertedClicksField;

    private bool numConvertedClicksFieldSpecified;

    public int numConversionEvents {
      get { return this.numConversionEventsField; }
      set {
        this.numConversionEventsField = value;
        this.numConversionEventsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numConversionEventsSpecified {
      get { return this.numConversionEventsFieldSpecified; }
      set { this.numConversionEventsFieldSpecified = value; }
    }

    public Money conversionValue {
      get { return this.conversionValueField; }
      set { this.conversionValueField = value; }
    }

    public string mostRecentConversionDate {
      get { return this.mostRecentConversionDateField; }
      set { this.mostRecentConversionDateField = value; }
    }

    public int numConvertedClicks {
      get { return this.numConvertedClicksField; }
      set {
        this.numConvertedClicksField = value;
        this.numConvertedClicksSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numConvertedClicksSpecified {
      get { return this.numConvertedClicksFieldSpecified; }
      set { this.numConvertedClicksFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConversionDeduplicationMode {
    ONE_PER_CLICK,
    MANY_PER_CLICK
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class WebsiteCallMetricsConversion : ConversionTracker {
    private long phoneCallDurationField;

    private bool phoneCallDurationFieldSpecified;

    private string snippetField;

    public long phoneCallDuration {
      get { return this.phoneCallDurationField; }
      set {
        this.phoneCallDurationField = value;
        this.phoneCallDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool phoneCallDurationSpecified {
      get { return this.phoneCallDurationFieldSpecified; }
      set { this.phoneCallDurationFieldSpecified = value; }
    }

    public string snippet {
      get { return this.snippetField; }
      set { this.snippetField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class UploadConversion : ConversionTracker {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AppConversion : ConversionTracker {
    private string appIdField;

    private AppConversionAppPlatform appPlatformField;

    private bool appPlatformFieldSpecified;

    private string snippetField;

    private AppConversionAppConversionType appConversionTypeField;

    private bool appConversionTypeFieldSpecified;

    private string appPostbackUrlField;

    public string appId {
      get { return this.appIdField; }
      set { this.appIdField = value; }
    }

    public AppConversionAppPlatform appPlatform {
      get { return this.appPlatformField; }
      set {
        this.appPlatformField = value;
        this.appPlatformSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool appPlatformSpecified {
      get { return this.appPlatformFieldSpecified; }
      set { this.appPlatformFieldSpecified = value; }
    }

    public string snippet {
      get { return this.snippetField; }
      set { this.snippetField = value; }
    }

    public AppConversionAppConversionType appConversionType {
      get { return this.appConversionTypeField; }
      set {
        this.appConversionTypeField = value;
        this.appConversionTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool appConversionTypeSpecified {
      get { return this.appConversionTypeFieldSpecified; }
      set { this.appConversionTypeFieldSpecified = value; }
    }

    public string appPostbackUrl {
      get { return this.appPostbackUrlField; }
      set { this.appPostbackUrlField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AppConversion.AppPlatform", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AppConversionAppPlatform {
    NONE,
    ITUNES,
    ANDROID_MARKET,
    MOBILE_APP_CHANNEL
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AppConversion.AppConversionType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AppConversionAppConversionType {
    NONE,
    DOWNLOAD,
    IN_APP_PURCHASE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdWordsConversionTracker : ConversionTracker {
    private string snippetField;

    private AdWordsConversionTrackerMarkupLanguage markupLanguageField;

    private bool markupLanguageFieldSpecified;

    private AdWordsConversionTrackerTextFormat textFormatField;

    private bool textFormatFieldSpecified;

    private string conversionPageLanguageField;

    private string backgroundColorField;

    private AdWordsConversionTrackerTrackingCodeType trackingCodeTypeField;

    private bool trackingCodeTypeFieldSpecified;

    public string snippet {
      get { return this.snippetField; }
      set { this.snippetField = value; }
    }

    public AdWordsConversionTrackerMarkupLanguage markupLanguage {
      get { return this.markupLanguageField; }
      set {
        this.markupLanguageField = value;
        this.markupLanguageSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool markupLanguageSpecified {
      get { return this.markupLanguageFieldSpecified; }
      set { this.markupLanguageFieldSpecified = value; }
    }

    public AdWordsConversionTrackerTextFormat textFormat {
      get { return this.textFormatField; }
      set {
        this.textFormatField = value;
        this.textFormatSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool textFormatSpecified {
      get { return this.textFormatFieldSpecified; }
      set { this.textFormatFieldSpecified = value; }
    }

    public string conversionPageLanguage {
      get { return this.conversionPageLanguageField; }
      set { this.conversionPageLanguageField = value; }
    }

    public string backgroundColor {
      get { return this.backgroundColorField; }
      set { this.backgroundColorField = value; }
    }

    public AdWordsConversionTrackerTrackingCodeType trackingCodeType {
      get { return this.trackingCodeTypeField; }
      set {
        this.trackingCodeTypeField = value;
        this.trackingCodeTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool trackingCodeTypeSpecified {
      get { return this.trackingCodeTypeFieldSpecified; }
      set { this.trackingCodeTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdWordsConversionTracker.MarkupLanguage", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdWordsConversionTrackerMarkupLanguage {
    HTML,
    CHTML,
    XHTML,
    WML
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdWordsConversionTracker.TextFormat", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdWordsConversionTrackerTextFormat {
    ONE_LINE,
    TWO_LINE,
    HIDDEN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdWordsConversionTracker.TrackingCodeType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdWordsConversionTrackerTrackingCodeType {
    WEBPAGE,
    CLICK_TO_CALL,
    ANDROID_REMARKETING,
    APPLE_IOS_REMARKETING
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdCallMetricsConversion : ConversionTracker {
    private long phoneCallDurationField;

    private bool phoneCallDurationFieldSpecified;

    public long phoneCallDuration {
      get { return this.phoneCallDurationField; }
      set {
        this.phoneCallDurationField = value;
        this.phoneCallDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool phoneCallDurationSpecified {
      get { return this.phoneCallDurationFieldSpecified; }
      set { this.phoneCallDurationFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConversionTrackerOperation : Operation {
    private ConversionTracker operandField;

    public ConversionTracker operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConversionTrackerPage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscapePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductServicePage))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LabelPage))]
  public abstract partial class NoStatsPage : Page {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConversionTrackerPage : NoStatsPage {
    private ConversionTracker[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public ConversionTracker[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ConversionTrackingError : ApiError {
    private ConversionTrackingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ConversionTrackingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ConversionTrackingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ConversionTrackingErrorReason {
    ALREADY_CREATED_CUSTOM_CONVERSION_TYPE,
    ANALYTICS_NOT_ALLOWED,
    CANNOT_ADD_CONVERSION_TYPE_SUBCLASS,
    CANNOT_CHANGE_APP_CONVERSION_TYPE,
    CANNOT_CHANGE_APP_PLATFORM,
    CANNNOT_CHANGE_CONVERSION_SUBCLASS,
    CANNOT_SET_HIDDEN_STATUS,
    CONVERSION_TYPE_NOT_FOUND,
    DOMAIN_EXCEPTION,
    INCONSISTENT_COUNTING_TYPE,
    DUPLICATE_APP_ID,
    DUPLICATE_NAME,
    EMAIL_FAILED,
    EXCEEDED_CONVERSION_TYPE_LIMIT,
    ID_IS_NULL,
    INVALID_APP_ID,
    INVALID_COLOR,
    INVALID_CONVERSION,
    INVALID_DATE_RANGE,
    INVALID_EMAIL_ADDRESS,
    INVALID_ORIGINAL_CONVERSION_TYPE_ID,
    MUST_SET_APP_PLATFORM_AND_APP_CONVERSION_TYPE_TOGETHER,
    NAME_ALREADY_EXISTS,
    NO_RECIPIENTS,
    NO_SNIPPET,
    TOO_MANY_WEBPAGES,
    UNKNOWN_SORTING_TYPE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CustomerServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CustomerService : AdWordsSoapClient, ICustomerService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CustomerService() {
      this.Url = "https://adwords.google.com/api/adwords/mcm/v201409/CustomerService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Customer get() {
      object[] results = this.Invoke("get", new object[0]);
      return ((Customer) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Customer mutate(Customer customer) {
      object[] results = this.Invoke("mutate", new object[] { customer });
      return ((Customer) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class ConversionTrackingSettings {
    private ConversionDeduplicationMode conversionOptimizerModeField;

    private bool conversionOptimizerModeFieldSpecified;

    public ConversionDeduplicationMode conversionOptimizerMode {
      get { return this.conversionOptimizerModeField; }
      set {
        this.conversionOptimizerModeField = value;
        this.conversionOptimizerModeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionOptimizerModeSpecified {
      get { return this.conversionOptimizerModeFieldSpecified; }
      set { this.conversionOptimizerModeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class Customer {
    private long customerIdField;

    private bool customerIdFieldSpecified;

    private string currencyCodeField;

    private string dateTimeZoneField;

    private string descriptiveNameField;

    private string companyNameField;

    private bool canManageClientsField;

    private bool canManageClientsFieldSpecified;

    private bool testAccountField;

    private bool testAccountFieldSpecified;

    private bool autoTaggingEnabledField;

    private bool autoTaggingEnabledFieldSpecified;

    private string trackingUrlTemplateField;

    private ConversionTrackingSettings conversionTrackingSettingsField;

    public long customerId {
      get { return this.customerIdField; }
      set {
        this.customerIdField = value;
        this.customerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool customerIdSpecified {
      get { return this.customerIdFieldSpecified; }
      set { this.customerIdFieldSpecified = value; }
    }

    public string currencyCode {
      get { return this.currencyCodeField; }
      set { this.currencyCodeField = value; }
    }

    public string dateTimeZone {
      get { return this.dateTimeZoneField; }
      set { this.dateTimeZoneField = value; }
    }

    public string descriptiveName {
      get { return this.descriptiveNameField; }
      set { this.descriptiveNameField = value; }
    }

    public string companyName {
      get { return this.companyNameField; }
      set { this.companyNameField = value; }
    }

    public bool canManageClients {
      get { return this.canManageClientsField; }
      set {
        this.canManageClientsField = value;
        this.canManageClientsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool canManageClientsSpecified {
      get { return this.canManageClientsFieldSpecified; }
      set { this.canManageClientsFieldSpecified = value; }
    }

    public bool testAccount {
      get { return this.testAccountField; }
      set {
        this.testAccountField = value;
        this.testAccountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool testAccountSpecified {
      get { return this.testAccountFieldSpecified; }
      set { this.testAccountFieldSpecified = value; }
    }

    public bool autoTaggingEnabled {
      get { return this.autoTaggingEnabledField; }
      set {
        this.autoTaggingEnabledField = value;
        this.autoTaggingEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool autoTaggingEnabledSpecified {
      get { return this.autoTaggingEnabledFieldSpecified; }
      set { this.autoTaggingEnabledFieldSpecified = value; }
    }

    public string trackingUrlTemplate {
      get { return this.trackingUrlTemplateField; }
      set { this.trackingUrlTemplateField = value; }
    }

    public ConversionTrackingSettings conversionTrackingSettings {
      get { return this.conversionTrackingSettingsField; }
      set { this.conversionTrackingSettingsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CustomerSyncServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CustomerSyncService : AdWordsSoapClient, ICustomerSyncService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CustomerSyncService() {
      this.Url = "https://adwords.google.com/api/adwords/ch/v201409/CustomerSyncService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/ch/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/ch/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CustomerChangeData get(CustomerSyncSelector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((CustomerChangeData) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public partial class FeedChangeData {
    private long feedIdField;

    private bool feedIdFieldSpecified;

    private ChangeStatus feedChangeStatusField;

    private bool feedChangeStatusFieldSpecified;

    private long[] changedFeedItemsField;

    private long[] removedFeedItemsField;

    public long feedId {
      get { return this.feedIdField; }
      set {
        this.feedIdField = value;
        this.feedIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedIdSpecified {
      get { return this.feedIdFieldSpecified; }
      set { this.feedIdFieldSpecified = value; }
    }

    public ChangeStatus feedChangeStatus {
      get { return this.feedChangeStatusField; }
      set {
        this.feedChangeStatusField = value;
        this.feedChangeStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedChangeStatusSpecified {
      get { return this.feedChangeStatusFieldSpecified; }
      set { this.feedChangeStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedFeedItems")]
    public long[] changedFeedItems {
      get { return this.changedFeedItemsField; }
      set { this.changedFeedItemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("removedFeedItems")]
    public long[] removedFeedItems {
      get { return this.removedFeedItemsField; }
      set { this.removedFeedItemsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public enum ChangeStatus {
    FIELDS_UNCHANGED,
    FIELDS_CHANGED,
    NEW
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public partial class AdGroupChangeData {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private ChangeStatus adGroupChangeStatusField;

    private bool adGroupChangeStatusFieldSpecified;

    private long[] changedAdsField;

    private long[] changedCriteriaField;

    private long[] removedCriteriaField;

    private long[] changedFeedsField;

    private long[] removedFeedsField;

    private long[] changedAdGroupBidModifierCriteriaField;

    private long[] removedAdGroupBidModifierCriteriaField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public ChangeStatus adGroupChangeStatus {
      get { return this.adGroupChangeStatusField; }
      set {
        this.adGroupChangeStatusField = value;
        this.adGroupChangeStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupChangeStatusSpecified {
      get { return this.adGroupChangeStatusFieldSpecified; }
      set { this.adGroupChangeStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedAds")]
    public long[] changedAds {
      get { return this.changedAdsField; }
      set { this.changedAdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedCriteria")]
    public long[] changedCriteria {
      get { return this.changedCriteriaField; }
      set { this.changedCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("removedCriteria")]
    public long[] removedCriteria {
      get { return this.removedCriteriaField; }
      set { this.removedCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedFeeds")]
    public long[] changedFeeds {
      get { return this.changedFeedsField; }
      set { this.changedFeedsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("removedFeeds")]
    public long[] removedFeeds {
      get { return this.removedFeedsField; }
      set { this.removedFeedsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedAdGroupBidModifierCriteria")]
    public long[] changedAdGroupBidModifierCriteria {
      get { return this.changedAdGroupBidModifierCriteriaField; }
      set { this.changedAdGroupBidModifierCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("removedAdGroupBidModifierCriteria")]
    public long[] removedAdGroupBidModifierCriteria {
      get { return this.removedAdGroupBidModifierCriteriaField; }
      set { this.removedAdGroupBidModifierCriteriaField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public partial class CampaignChangeData {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private ChangeStatus campaignChangeStatusField;

    private bool campaignChangeStatusFieldSpecified;

    private AdGroupChangeData[] changedAdGroupsField;

    private long[] addedCampaignCriteriaField;

    private long[] removedCampaignCriteriaField;

    private long[] addedAdExtensionsField;

    private long[] removedAdExtensionsField;

    private long[] changedFeedsField;

    private long[] removedFeedsField;

    private bool campaignTargetingChangedField;

    private bool campaignTargetingChangedFieldSpecified;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public ChangeStatus campaignChangeStatus {
      get { return this.campaignChangeStatusField; }
      set {
        this.campaignChangeStatusField = value;
        this.campaignChangeStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignChangeStatusSpecified {
      get { return this.campaignChangeStatusFieldSpecified; }
      set { this.campaignChangeStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedAdGroups")]
    public AdGroupChangeData[] changedAdGroups {
      get { return this.changedAdGroupsField; }
      set { this.changedAdGroupsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("addedCampaignCriteria")]
    public long[] addedCampaignCriteria {
      get { return this.addedCampaignCriteriaField; }
      set { this.addedCampaignCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("removedCampaignCriteria")]
    public long[] removedCampaignCriteria {
      get { return this.removedCampaignCriteriaField; }
      set { this.removedCampaignCriteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("addedAdExtensions")]
    public long[] addedAdExtensions {
      get { return this.addedAdExtensionsField; }
      set { this.addedAdExtensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("removedAdExtensions")]
    public long[] removedAdExtensions {
      get { return this.removedAdExtensionsField; }
      set { this.removedAdExtensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedFeeds")]
    public long[] changedFeeds {
      get { return this.changedFeedsField; }
      set { this.changedFeedsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("removedFeeds")]
    public long[] removedFeeds {
      get { return this.removedFeedsField; }
      set { this.removedFeedsField = value; }
    }

    public bool campaignTargetingChanged {
      get { return this.campaignTargetingChangedField; }
      set {
        this.campaignTargetingChangedField = value;
        this.campaignTargetingChangedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignTargetingChangedSpecified {
      get { return this.campaignTargetingChangedFieldSpecified; }
      set { this.campaignTargetingChangedFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public partial class CustomerChangeData {
    private CampaignChangeData[] changedCampaignsField;

    private FeedChangeData[] changedFeedsField;

    private string lastChangeTimestampField;

    [System.Xml.Serialization.XmlElementAttribute("changedCampaigns")]
    public CampaignChangeData[] changedCampaigns {
      get { return this.changedCampaignsField; }
      set { this.changedCampaignsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("changedFeeds")]
    public FeedChangeData[] changedFeeds {
      get { return this.changedFeedsField; }
      set { this.changedFeedsField = value; }
    }

    public string lastChangeTimestamp {
      get { return this.lastChangeTimestampField; }
      set { this.lastChangeTimestampField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DateTimeRange {
    private string minField;

    private string maxField;

    public string min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public string max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public partial class CustomerSyncSelector {
    private DateTimeRange dateTimeRangeField;

    private long[] campaignIdsField;

    private long[] feedIdsField;

    public DateTimeRange dateTimeRange {
      get { return this.dateTimeRangeField; }
      set { this.dateTimeRangeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get { return this.campaignIdsField; }
      set { this.campaignIdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("feedIds")]
    public long[] feedIds {
      get { return this.feedIdsField; }
      set { this.feedIdsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public partial class CustomerSyncError : ApiError {
    private CustomerSyncErrorReason reasonField;

    private bool reasonFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    public CustomerSyncErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CustomerSyncError.Reason", Namespace = "https://adwords.google.com/api/adwords/ch/v201409")]
  public enum CustomerSyncErrorReason {
    INVALID_CAMPAIGN_ID,
    INVALID_FEED_ID,
    INVALID_DATE_RANGE,
    TOO_MANY_CHANGES
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CustomerFeedServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CustomerFeedService : AdWordsSoapClient, ICustomerFeedService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CustomerFeedService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/CustomerFeedService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CustomerFeedPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((CustomerFeedPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CustomerFeedReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CustomerFeedOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((CustomerFeedReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CustomerFeedPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((CustomerFeedPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CustomerFeedReturnValue : ListReturnValue {
    private CustomerFeed[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CustomerFeed[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CustomerFeed {
    private long feedIdField;

    private bool feedIdFieldSpecified;

    private Function matchingFunctionField;

    private int[] placeholderTypesField;

    private CustomerFeedStatus statusField;

    private bool statusFieldSpecified;

    public long feedId {
      get { return this.feedIdField; }
      set {
        this.feedIdField = value;
        this.feedIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedIdSpecified {
      get { return this.feedIdFieldSpecified; }
      set { this.feedIdFieldSpecified = value; }
    }

    public Function matchingFunction {
      get { return this.matchingFunctionField; }
      set { this.matchingFunctionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("placeholderTypes")]
    public int[] placeholderTypes {
      get { return this.placeholderTypesField; }
      set { this.placeholderTypesField = value; }
    }

    public CustomerFeedStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CustomerFeed.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CustomerFeedStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CustomerFeedOperation : Operation {
    private CustomerFeed operandField;

    public CustomerFeed operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CustomerFeedPage : NullStatsPage {
    private CustomerFeed[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CustomerFeed[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CustomerFeedError : ApiError {
    private CustomerFeedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CustomerFeedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CustomerFeedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CustomerFeedErrorReason {
    FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE,
    INVALID_ID,
    CANNOT_ADD_ALREADY_EXISTING_CUSTOMER_FEED,
    CANNOT_MODIFY_REMOVED_CUSTOMER_FEED,
    INVALID_PLACEHOLDER_TYPES,
    MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE,
    PLACEHOLDER_TYPE_NOT_ALLOWED_ON_CUSTOMER_FEED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "DataServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataEntry))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class DataService : AdWordsSoapClient, IDataService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public DataService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/DataService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupBidLandscapePage getAdGroupBidLandscape(Selector serviceSelector) {
      object[] results = this.Invoke("getAdGroupBidLandscape", new object[] { serviceSelector });
      return ((AdGroupBidLandscapePage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CriterionBidLandscapePage getCriterionBidLandscape(Selector serviceSelector) {
      object[] results = this.Invoke("getCriterionBidLandscape", new object[] { serviceSelector });
      return ((CriterionBidLandscapePage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual DomainCategoryPage getDomainCategory(Selector serviceSelector) {
      object[] results = this.Invoke("getDomainCategory", new object[] { serviceSelector });
      return ((DomainCategoryPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupBidLandscapePage queryAdGroupBidLandscape(string query) {
      object[] results = this.Invoke("queryAdGroupBidLandscape", new object[] { query });
      return ((AdGroupBidLandscapePage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CriterionBidLandscapePage queryCriterionBidLandscape(string query) {
      object[] results = this.Invoke("queryCriterionBidLandscape", new object[] { query });
      return ((CriterionBidLandscapePage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual DomainCategoryPage queryDomainCategory(string query) {
      object[] results = this.Invoke("queryDomainCategory", new object[] { query });
      return ((DomainCategoryPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LevelOfDetail {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BidLandscape.LandscapePoint", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BidLandscapeLandscapePoint {
    private Money bidField;

    private long clicksField;

    private bool clicksFieldSpecified;

    private Money costField;

    private Money marginalCpcField;

    private long impressionsField;

    private bool impressionsFieldSpecified;

    private long promotedImpressionsField;

    private bool promotedImpressionsFieldSpecified;

    public Money bid {
      get { return this.bidField; }
      set { this.bidField = value; }
    }

    public long clicks {
      get { return this.clicksField; }
      set {
        this.clicksField = value;
        this.clicksSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clicksSpecified {
      get { return this.clicksFieldSpecified; }
      set { this.clicksFieldSpecified = value; }
    }

    public Money cost {
      get { return this.costField; }
      set { this.costField = value; }
    }

    public Money marginalCpc {
      get { return this.marginalCpcField; }
      set { this.marginalCpcField = value; }
    }

    public long impressions {
      get { return this.impressionsField; }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get { return this.impressionsFieldSpecified; }
      set { this.impressionsFieldSpecified = value; }
    }

    public long promotedImpressions {
      get { return this.promotedImpressionsField; }
      set {
        this.promotedImpressionsField = value;
        this.promotedImpressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool promotedImpressionsSpecified {
      get { return this.promotedImpressionsFieldSpecified; }
      set { this.promotedImpressionsFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DimensionProperties))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainCategory))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BidLandscape))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscape))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscape))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class DataEntry {
    private string dataEntryTypeField;

    [System.Xml.Serialization.XmlElementAttribute("DataEntry.Type")]
    public string DataEntryType {
      get { return this.dataEntryTypeField; }
      set { this.dataEntryTypeField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainCategory))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class DimensionProperties : DataEntry {
    private LevelOfDetail levelOfDetailField;

    public LevelOfDetail levelOfDetail {
      get { return this.levelOfDetailField; }
      set { this.levelOfDetailField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DomainCategory : DimensionProperties {
    private string categoryField;

    private double coverageField;

    private bool coverageFieldSpecified;

    private string domainNameField;

    private string isoLanguageField;

    public string category {
      get { return this.categoryField; }
      set { this.categoryField = value; }
    }

    public double coverage {
      get { return this.coverageField; }
      set {
        this.coverageField = value;
        this.coverageSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool coverageSpecified {
      get { return this.coverageFieldSpecified; }
      set { this.coverageFieldSpecified = value; }
    }

    public string domainName {
      get { return this.domainNameField; }
      set { this.domainNameField = value; }
    }

    public string isoLanguage {
      get { return this.isoLanguageField; }
      set { this.isoLanguageField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionBidLandscape))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupBidLandscape))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class BidLandscape : DataEntry {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private string startDateField;

    private string endDateField;

    private BidLandscapeLandscapePoint[] landscapePointsField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public string startDate {
      get { return this.startDateField; }
      set { this.startDateField = value; }
    }

    public string endDate {
      get { return this.endDateField; }
      set { this.endDateField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("landscapePoints")]
    public BidLandscapeLandscapePoint[] landscapePoints {
      get { return this.landscapePointsField; }
      set { this.landscapePointsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CriterionBidLandscape : BidLandscape {
    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    public long criterionId {
      get { return this.criterionIdField; }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get { return this.criterionIdFieldSpecified; }
      set { this.criterionIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupBidLandscape : BidLandscape {
    private AdGroupBidLandscapeType typeField;

    private bool typeFieldSpecified;

    private bool landscapeCurrentField;

    private bool landscapeCurrentFieldSpecified;

    public AdGroupBidLandscapeType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public bool landscapeCurrent {
      get { return this.landscapeCurrentField; }
      set {
        this.landscapeCurrentField = value;
        this.landscapeCurrentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool landscapeCurrentSpecified {
      get { return this.landscapeCurrentFieldSpecified; }
      set { this.landscapeCurrentFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupBidLandscape.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupBidLandscapeType {
    UNIFORM,
    DEFAULT,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CriterionBidLandscapePage : NoStatsPage {
    private CriterionBidLandscape[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CriterionBidLandscape[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupBidLandscapePage : NoStatsPage {
    private AdGroupBidLandscape[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupBidLandscape[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DomainCategoryPage : Page {
    private DomainCategory[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public DomainCategory[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DataError : ApiError {
    private DataErrorReason reasonField;

    private bool reasonFieldSpecified;

    public DataErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DataError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum DataErrorReason {
    CANNOT_CREATE_TABLE_ENTRY,
    NO_TABLE_ENTRY_CLASS_FOR_VIEW_TYPE,
    TABLE_SERVICE_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupAdServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupAdService : AdWordsSoapClient, IAdGroupAdService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupAdService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/AdGroupAdService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupAdPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((AdGroupAdPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupAdReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupAdOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((AdGroupAdReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupAdLabelReturnValue mutateLabel([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupAdLabelOperation[] operations) {
      object[] results = this.Invoke("mutateLabel", new object[] { operations });
      return ((AdGroupAdLabelReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupAdPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((AdGroupAdPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Ad[] upgradeUrl([System.Xml.Serialization.XmlElementAttribute("operations")]
AdUrlUpgrade[] operations) {
      object[] results = this.Invoke("upgradeUrl", new object[] { operations });
      return ((Ad[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdUrlUpgrade {
    private long adIdField;

    private bool adIdFieldSpecified;

    private string finalUrlField;

    private string finalMobileUrlField;

    private string trackingUrlTemplateField;

    public long adId {
      get { return this.adIdField; }
      set {
        this.adIdField = value;
        this.adIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adIdSpecified {
      get { return this.adIdFieldSpecified; }
      set { this.adIdFieldSpecified = value; }
    }

    public string finalUrl {
      get { return this.finalUrlField; }
      set { this.finalUrlField = value; }
    }

    public string finalMobileUrl {
      get { return this.finalMobileUrlField; }
      set { this.finalMobileUrlField = value; }
    }

    public string trackingUrlTemplate {
      get { return this.trackingUrlTemplateField; }
      set { this.trackingUrlTemplateField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdReturnValue : ListReturnValue {
    private AdGroupAd[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupAd[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAd {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private Ad adField;

    private AdGroupAdExperimentData experimentDataField;

    private AdGroupAdStatus statusField;

    private bool statusFieldSpecified;

    private AdGroupAdApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private string[] disapprovalReasonsField;

    private bool trademarkDisapprovedField;

    private bool trademarkDisapprovedFieldSpecified;

    private Label[] labelsField;

    private String_StringMapEntry[] forwardCompatibilityMapField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public Ad ad {
      get { return this.adField; }
      set { this.adField = value; }
    }

    public AdGroupAdExperimentData experimentData {
      get { return this.experimentDataField; }
      set { this.experimentDataField = value; }
    }

    public AdGroupAdStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public AdGroupAdApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("disapprovalReasons")]
    public string[] disapprovalReasons {
      get { return this.disapprovalReasonsField; }
      set { this.disapprovalReasonsField = value; }
    }

    public bool trademarkDisapproved {
      get { return this.trademarkDisapprovedField; }
      set {
        this.trademarkDisapprovedField = value;
        this.trademarkDisapprovedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool trademarkDisapprovedSpecified {
      get { return this.trademarkDisapprovedFieldSpecified; }
      set { this.trademarkDisapprovedFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("labels")]
    public Label[] labels {
      get { return this.labelsField; }
      set { this.labelsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("forwardCompatibilityMap")]
    public String_StringMapEntry[] forwardCompatibilityMap {
      get { return this.forwardCompatibilityMapField; }
      set { this.forwardCompatibilityMapField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DynamicSearchAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TemplateAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RichMediaAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThirdPartyRedirectAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileImageAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImageAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeprecatedAd))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CallOnlyAd))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Ad {
    private long idField;

    private bool idFieldSpecified;

    private string urlField;

    private string displayUrlField;

    private string[] finalUrlsField;

    private string[] finalMobileUrlsField;

    private AppUrl[] finalAppUrlsField;

    private string trackingUrlTemplateField;

    private CustomParameters urlCustomParametersField;

    private long devicePreferenceField;

    private bool devicePreferenceFieldSpecified;

    private string adTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string url {
      get { return this.urlField; }
      set { this.urlField = value; }
    }

    public string displayUrl {
      get { return this.displayUrlField; }
      set { this.displayUrlField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("finalUrls")]
    public string[] finalUrls {
      get { return this.finalUrlsField; }
      set { this.finalUrlsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("finalMobileUrls")]
    public string[] finalMobileUrls {
      get { return this.finalMobileUrlsField; }
      set { this.finalMobileUrlsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("finalAppUrls")]
    public AppUrl[] finalAppUrls {
      get { return this.finalAppUrlsField; }
      set { this.finalAppUrlsField = value; }
    }

    public string trackingUrlTemplate {
      get { return this.trackingUrlTemplateField; }
      set { this.trackingUrlTemplateField = value; }
    }

    public CustomParameters urlCustomParameters {
      get { return this.urlCustomParametersField; }
      set { this.urlCustomParametersField = value; }
    }

    public long devicePreference {
      get { return this.devicePreferenceField; }
      set {
        this.devicePreferenceField = value;
        this.devicePreferenceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool devicePreferenceSpecified {
      get { return this.devicePreferenceFieldSpecified; }
      set { this.devicePreferenceFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Ad.Type")]
    public string AdType {
      get { return this.adTypeField; }
      set { this.adTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AppUrl {
    private string urlField;

    private AppUrlOsType osTypeField;

    private bool osTypeFieldSpecified;

    public string url {
      get { return this.urlField; }
      set { this.urlField = value; }
    }

    public AppUrlOsType osType {
      get { return this.osTypeField; }
      set {
        this.osTypeField = value;
        this.osTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool osTypeSpecified {
      get { return this.osTypeFieldSpecified; }
      set { this.osTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AppUrl.OsType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AppUrlOsType {
    OS_TYPE_IOS,
    OS_TYPE_ANDROID,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DynamicSearchAd : Ad {
    private string description1Field;

    private string description2Field;

    public string description1 {
      get { return this.description1Field; }
      set { this.description1Field = value; }
    }

    public string description2 {
      get { return this.description2Field; }
      set { this.description2Field = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TextAd : Ad {
    private string headlineField;

    private string description1Field;

    private string description2Field;

    public string headline {
      get { return this.headlineField; }
      set { this.headlineField = value; }
    }

    public string description1 {
      get { return this.description1Field; }
      set { this.description1Field = value; }
    }

    public string description2 {
      get { return this.description2Field; }
      set { this.description2Field = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TemplateAd : Ad {
    private long templateIdField;

    private bool templateIdFieldSpecified;

    private AdUnionId adUnionIdField;

    private TemplateElement[] templateElementsField;

    private Image adAsImageField;

    private Dimensions dimensionsField;

    private string nameField;

    private int durationField;

    private bool durationFieldSpecified;

    private long originAdIdField;

    private bool originAdIdFieldSpecified;

    public long templateId {
      get { return this.templateIdField; }
      set {
        this.templateIdField = value;
        this.templateIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool templateIdSpecified {
      get { return this.templateIdFieldSpecified; }
      set { this.templateIdFieldSpecified = value; }
    }

    public AdUnionId adUnionId {
      get { return this.adUnionIdField; }
      set { this.adUnionIdField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("templateElements")]
    public TemplateElement[] templateElements {
      get { return this.templateElementsField; }
      set { this.templateElementsField = value; }
    }

    public Image adAsImage {
      get { return this.adAsImageField; }
      set { this.adAsImageField = value; }
    }

    public Dimensions dimensions {
      get { return this.dimensionsField; }
      set { this.dimensionsField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public int duration {
      get { return this.durationField; }
      set {
        this.durationField = value;
        this.durationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationSpecified {
      get { return this.durationFieldSpecified; }
      set { this.durationFieldSpecified = value; }
    }

    public long originAdId {
      get { return this.originAdIdField; }
      set {
        this.originAdIdField = value;
        this.originAdIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool originAdIdSpecified {
      get { return this.originAdIdFieldSpecified; }
      set { this.originAdIdFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(TempAdUnionId))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdUnionId {
    private long idField;

    private bool idFieldSpecified;

    private string adUnionIdTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdUnionId.Type")]
    public string AdUnionIdType {
      get { return this.adUnionIdTypeField; }
      set { this.adUnionIdTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TempAdUnionId : AdUnionId {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TemplateElement {
    private string uniqueNameField;

    private TemplateElementField[] fieldsField;

    public string uniqueName {
      get { return this.uniqueNameField; }
      set { this.uniqueNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("fields")]
    public TemplateElementField[] fields {
      get { return this.fieldsField; }
      set { this.fieldsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TemplateElementField {
    private string nameField;

    private TemplateElementFieldType typeField;

    private bool typeFieldSpecified;

    private string fieldTextField;

    private Media fieldMediaField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public TemplateElementFieldType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public string fieldText {
      get { return this.fieldTextField; }
      set { this.fieldTextField = value; }
    }

    public Media fieldMedia {
      get { return this.fieldMediaField; }
      set { this.fieldMediaField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TemplateElementField.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum TemplateElementFieldType {
    ADDRESS,
    AUDIO,
    ENUM,
    IMAGE,
    BACKGROUND_IMAGE,
    NUMBER,
    TEXT,
    URL,
    VIDEO,
    VISIBLE_URL,
    UNKNOWN
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Video))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Image))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Audio))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Media {
    private long mediaIdField;

    private bool mediaIdFieldSpecified;

    private MediaMediaType typeField;

    private bool typeFieldSpecified;

    private long referenceIdField;

    private bool referenceIdFieldSpecified;

    private Media_Size_DimensionsMapEntry[] dimensionsField;

    private Media_Size_StringMapEntry[] urlsField;

    private MediaMimeType mimeTypeField;

    private bool mimeTypeFieldSpecified;

    private string sourceUrlField;

    private string nameField;

    private long fileSizeField;

    private bool fileSizeFieldSpecified;

    private string creationTimeField;

    private string mediaTypeField;

    public long mediaId {
      get { return this.mediaIdField; }
      set {
        this.mediaIdField = value;
        this.mediaIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mediaIdSpecified {
      get { return this.mediaIdFieldSpecified; }
      set { this.mediaIdFieldSpecified = value; }
    }

    public MediaMediaType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public long referenceId {
      get { return this.referenceIdField; }
      set {
        this.referenceIdField = value;
        this.referenceIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool referenceIdSpecified {
      get { return this.referenceIdFieldSpecified; }
      set { this.referenceIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("dimensions")]
    public Media_Size_DimensionsMapEntry[] dimensions {
      get { return this.dimensionsField; }
      set { this.dimensionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("urls")]
    public Media_Size_StringMapEntry[] urls {
      get { return this.urlsField; }
      set { this.urlsField = value; }
    }

    public MediaMimeType mimeType {
      get { return this.mimeTypeField; }
      set {
        this.mimeTypeField = value;
        this.mimeTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool mimeTypeSpecified {
      get { return this.mimeTypeFieldSpecified; }
      set { this.mimeTypeFieldSpecified = value; }
    }

    public string sourceUrl {
      get { return this.sourceUrlField; }
      set { this.sourceUrlField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public long fileSize {
      get { return this.fileSizeField; }
      set {
        this.fileSizeField = value;
        this.fileSizeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool fileSizeSpecified {
      get { return this.fileSizeFieldSpecified; }
      set { this.fileSizeFieldSpecified = value; }
    }

    public string creationTime {
      get { return this.creationTimeField; }
      set { this.creationTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Media.Type")]
    public string MediaType {
      get { return this.mediaTypeField; }
      set { this.mediaTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MediaType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MediaMediaType {
    AUDIO,
    DYNAMIC_IMAGE,
    ICON,
    IMAGE,
    STANDARD_ICON,
    VIDEO
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Media_Size_DimensionsMapEntry {
    private MediaSize keyField;

    private bool keyFieldSpecified;

    private Dimensions valueField;

    public MediaSize key {
      get { return this.keyField; }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get { return this.keyFieldSpecified; }
      set { this.keyFieldSpecified = value; }
    }

    public Dimensions value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.Size", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MediaSize {
    FULL,
    SHRUNKEN,
    PREVIEW,
    VIDEO_THUMBNAIL
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Dimensions {
    private int widthField;

    private bool widthFieldSpecified;

    private int heightField;

    private bool heightFieldSpecified;

    public int width {
      get { return this.widthField; }
      set {
        this.widthField = value;
        this.widthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool widthSpecified {
      get { return this.widthFieldSpecified; }
      set { this.widthFieldSpecified = value; }
    }

    public int height {
      get { return this.heightField; }
      set {
        this.heightField = value;
        this.heightSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool heightSpecified {
      get { return this.heightFieldSpecified; }
      set { this.heightFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Media_Size_StringMapEntry {
    private MediaSize keyField;

    private bool keyFieldSpecified;

    private string valueField;

    public MediaSize key {
      get { return this.keyField; }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get { return this.keyFieldSpecified; }
      set { this.keyFieldSpecified = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Media.MimeType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MediaMimeType {
    IMAGE_JPEG,
    IMAGE_GIF,
    IMAGE_PNG,
    FLASH,
    TEXT_HTML,
    PDF,
    MSWORD,
    MSEXCEL,
    RTF,
    AUDIO_WAV,
    AUDIO_MP3
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Video : Media {
    private long durationMillisField;

    private bool durationMillisFieldSpecified;

    private string streamingUrlField;

    private bool readyToPlayOnTheWebField;

    private bool readyToPlayOnTheWebFieldSpecified;

    private string industryStandardCommercialIdentifierField;

    private string advertisingIdField;

    private string youTubeVideoIdStringField;

    public long durationMillis {
      get { return this.durationMillisField; }
      set {
        this.durationMillisField = value;
        this.durationMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationMillisSpecified {
      get { return this.durationMillisFieldSpecified; }
      set { this.durationMillisFieldSpecified = value; }
    }

    public string streamingUrl {
      get { return this.streamingUrlField; }
      set { this.streamingUrlField = value; }
    }

    public bool readyToPlayOnTheWeb {
      get { return this.readyToPlayOnTheWebField; }
      set {
        this.readyToPlayOnTheWebField = value;
        this.readyToPlayOnTheWebSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool readyToPlayOnTheWebSpecified {
      get { return this.readyToPlayOnTheWebFieldSpecified; }
      set { this.readyToPlayOnTheWebFieldSpecified = value; }
    }

    public string industryStandardCommercialIdentifier {
      get { return this.industryStandardCommercialIdentifierField; }
      set { this.industryStandardCommercialIdentifierField = value; }
    }

    public string advertisingId {
      get { return this.advertisingIdField; }
      set { this.advertisingIdField = value; }
    }

    public string youTubeVideoIdString {
      get { return this.youTubeVideoIdStringField; }
      set { this.youTubeVideoIdStringField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Image : Media {
    private byte[] dataField;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] data {
      get { return this.dataField; }
      set { this.dataField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Audio : Media {
    private long durationMillisField;

    private bool durationMillisFieldSpecified;

    private string streamingUrlField;

    private bool readyToPlayOnTheWebField;

    private bool readyToPlayOnTheWebFieldSpecified;

    public long durationMillis {
      get { return this.durationMillisField; }
      set {
        this.durationMillisField = value;
        this.durationMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool durationMillisSpecified {
      get { return this.durationMillisFieldSpecified; }
      set { this.durationMillisFieldSpecified = value; }
    }

    public string streamingUrl {
      get { return this.streamingUrlField; }
      set { this.streamingUrlField = value; }
    }

    public bool readyToPlayOnTheWeb {
      get { return this.readyToPlayOnTheWebField; }
      set {
        this.readyToPlayOnTheWebField = value;
        this.readyToPlayOnTheWebSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool readyToPlayOnTheWebSpecified {
      get { return this.readyToPlayOnTheWebFieldSpecified; }
      set { this.readyToPlayOnTheWebFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThirdPartyRedirectAd))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class RichMediaAd : Ad {
    private string nameField;

    private Dimensions dimensionsField;

    private string snippetField;

    private string impressionBeaconUrlField;

    private int adDurationField;

    private bool adDurationFieldSpecified;

    private long certifiedVendorFormatIdField;

    private bool certifiedVendorFormatIdFieldSpecified;

    private string sourceUrlField;

    private RichMediaAdRichMediaAdType richMediaAdTypeField;

    private bool richMediaAdTypeFieldSpecified;

    private RichMediaAdAdAttribute[] adAttributesField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public Dimensions dimensions {
      get { return this.dimensionsField; }
      set { this.dimensionsField = value; }
    }

    public string snippet {
      get { return this.snippetField; }
      set { this.snippetField = value; }
    }

    public string impressionBeaconUrl {
      get { return this.impressionBeaconUrlField; }
      set { this.impressionBeaconUrlField = value; }
    }

    public int adDuration {
      get { return this.adDurationField; }
      set {
        this.adDurationField = value;
        this.adDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adDurationSpecified {
      get { return this.adDurationFieldSpecified; }
      set { this.adDurationFieldSpecified = value; }
    }

    public long certifiedVendorFormatId {
      get { return this.certifiedVendorFormatIdField; }
      set {
        this.certifiedVendorFormatIdField = value;
        this.certifiedVendorFormatIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool certifiedVendorFormatIdSpecified {
      get { return this.certifiedVendorFormatIdFieldSpecified; }
      set { this.certifiedVendorFormatIdFieldSpecified = value; }
    }

    public string sourceUrl {
      get { return this.sourceUrlField; }
      set { this.sourceUrlField = value; }
    }

    public RichMediaAdRichMediaAdType richMediaAdType {
      get { return this.richMediaAdTypeField; }
      set {
        this.richMediaAdTypeField = value;
        this.richMediaAdTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool richMediaAdTypeSpecified {
      get { return this.richMediaAdTypeFieldSpecified; }
      set { this.richMediaAdTypeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adAttributes")]
    public RichMediaAdAdAttribute[] adAttributes {
      get { return this.adAttributesField; }
      set { this.adAttributesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RichMediaAd.RichMediaAdType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RichMediaAdRichMediaAdType {
    STANDARD,
    IN_STREAM_VIDEO
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "RichMediaAd.AdAttribute", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum RichMediaAdAdAttribute {
    UNKNOWN,
    ROLL_OVER_TO_EXPAND,
    SSL
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ThirdPartyRedirectAd : RichMediaAd {
    private bool isCookieTargetedField;

    private bool isCookieTargetedFieldSpecified;

    private bool isUserInterestTargetedField;

    private bool isUserInterestTargetedFieldSpecified;

    private bool isTaggedField;

    private bool isTaggedFieldSpecified;

    private VideoType[] videoTypesField;

    private ThirdPartyRedirectAdExpandingDirection[] expandingDirectionsField;

    public bool isCookieTargeted {
      get { return this.isCookieTargetedField; }
      set {
        this.isCookieTargetedField = value;
        this.isCookieTargetedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isCookieTargetedSpecified {
      get { return this.isCookieTargetedFieldSpecified; }
      set { this.isCookieTargetedFieldSpecified = value; }
    }

    public bool isUserInterestTargeted {
      get { return this.isUserInterestTargetedField; }
      set {
        this.isUserInterestTargetedField = value;
        this.isUserInterestTargetedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isUserInterestTargetedSpecified {
      get { return this.isUserInterestTargetedFieldSpecified; }
      set { this.isUserInterestTargetedFieldSpecified = value; }
    }

    public bool isTagged {
      get { return this.isTaggedField; }
      set {
        this.isTaggedField = value;
        this.isTaggedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isTaggedSpecified {
      get { return this.isTaggedFieldSpecified; }
      set { this.isTaggedFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("videoTypes")]
    public VideoType[] videoTypes {
      get { return this.videoTypesField; }
      set { this.videoTypesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("expandingDirections")]
    public ThirdPartyRedirectAdExpandingDirection[] expandingDirections {
      get { return this.expandingDirectionsField; }
      set { this.expandingDirectionsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum VideoType {
    ADOBE,
    REALPLAYER,
    QUICKTIME,
    WINDOWSMEDIA
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ThirdPartyRedirectAd.ExpandingDirection", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ThirdPartyRedirectAdExpandingDirection {
    UNKNOWN,
    EXPANDING_UP,
    EXPANDING_DOWN,
    EXPANDING_LEFT,
    EXPANDING_RIGHT,
    EXPANDING_UPLEFT,
    EXPANDING_UPRIGHT,
    EXPANDING_DOWNLEFT,
    EXPANDING_DOWNRIGHT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductAd : Ad {
    private string promotionLineField;

    public string promotionLine {
      get { return this.promotionLineField; }
      set { this.promotionLineField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MobileImageAd : Ad {
    private MarkupLanguageType[] markupLanguagesField;

    private string[] mobileCarriersField;

    private Image imageField;

    [System.Xml.Serialization.XmlElementAttribute("markupLanguages")]
    public MarkupLanguageType[] markupLanguages {
      get { return this.markupLanguagesField; }
      set { this.markupLanguagesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("mobileCarriers")]
    public string[] mobileCarriers {
      get { return this.mobileCarriersField; }
      set { this.mobileCarriersField = value; }
    }

    public Image image {
      get { return this.imageField; }
      set { this.imageField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MarkupLanguageType {
    HTML,
    CHTML,
    XHTML,
    WML
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MobileAd : Ad {
    private string headlineField;

    private string descriptionField;

    private MarkupLanguageType[] markupLanguagesField;

    private string[] mobileCarriersField;

    private string businessNameField;

    private string countryCodeField;

    private string phoneNumberField;

    public string headline {
      get { return this.headlineField; }
      set { this.headlineField = value; }
    }

    public string description {
      get { return this.descriptionField; }
      set { this.descriptionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("markupLanguages")]
    public MarkupLanguageType[] markupLanguages {
      get { return this.markupLanguagesField; }
      set { this.markupLanguagesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("mobileCarriers")]
    public string[] mobileCarriers {
      get { return this.mobileCarriersField; }
      set { this.mobileCarriersField = value; }
    }

    public string businessName {
      get { return this.businessNameField; }
      set { this.businessNameField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }

    public string phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ImageAd : Ad {
    private Image imageField;

    private string nameField;

    private long adToCopyImageFromField;

    private bool adToCopyImageFromFieldSpecified;

    public Image image {
      get { return this.imageField; }
      set { this.imageField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public long adToCopyImageFrom {
      get { return this.adToCopyImageFromField; }
      set {
        this.adToCopyImageFromField = value;
        this.adToCopyImageFromSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adToCopyImageFromSpecified {
      get { return this.adToCopyImageFromFieldSpecified; }
      set { this.adToCopyImageFromFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class DeprecatedAd : Ad {
    private string nameField;

    private DeprecatedAdType typeField;

    private bool typeFieldSpecified;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public DeprecatedAdType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DeprecatedAd.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum DeprecatedAdType {
    VIDEO,
    CLICK_TO_CALL,
    IN_STREAM_VIDEO,
    FROOGLE,
    TEXT_LINK,
    GADGET,
    PRINT,
    TEXT_WIDE,
    GADGET_TEMPLATE,
    TEXT_WITH_VIDEO,
    AUDIO,
    LOCAL_BUSINESS_AD,
    AUDIO_TEMPLATE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CallOnlyAd : Ad {
    private string countryCodeField;

    private string phoneNumberField;

    private string businessNameField;

    private string description1Field;

    private string description2Field;

    private bool callTrackedField;

    private bool callTrackedFieldSpecified;

    private long conversionTypeIdField;

    private bool conversionTypeIdFieldSpecified;

    private string phoneNumberVerificationUrlField;

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }

    public string phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }

    public string businessName {
      get { return this.businessNameField; }
      set { this.businessNameField = value; }
    }

    public string description1 {
      get { return this.description1Field; }
      set { this.description1Field = value; }
    }

    public string description2 {
      get { return this.description2Field; }
      set { this.description2Field = value; }
    }

    public bool callTracked {
      get { return this.callTrackedField; }
      set {
        this.callTrackedField = value;
        this.callTrackedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool callTrackedSpecified {
      get { return this.callTrackedFieldSpecified; }
      set { this.callTrackedFieldSpecified = value; }
    }

    public long conversionTypeId {
      get { return this.conversionTypeIdField; }
      set {
        this.conversionTypeIdField = value;
        this.conversionTypeIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionTypeIdSpecified {
      get { return this.conversionTypeIdFieldSpecified; }
      set { this.conversionTypeIdFieldSpecified = value; }
    }

    public string phoneNumberVerificationUrl {
      get { return this.phoneNumberVerificationUrlField; }
      set { this.phoneNumberVerificationUrlField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdExperimentData {
    private long experimentIdField;

    private bool experimentIdFieldSpecified;

    private ExperimentDeltaStatus experimentDeltaStatusField;

    private bool experimentDeltaStatusFieldSpecified;

    private ExperimentDataStatus experimentDataStatusField;

    private bool experimentDataStatusFieldSpecified;

    public long experimentId {
      get { return this.experimentIdField; }
      set {
        this.experimentIdField = value;
        this.experimentIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentIdSpecified {
      get { return this.experimentIdFieldSpecified; }
      set { this.experimentIdFieldSpecified = value; }
    }

    public ExperimentDeltaStatus experimentDeltaStatus {
      get { return this.experimentDeltaStatusField; }
      set {
        this.experimentDeltaStatusField = value;
        this.experimentDeltaStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDeltaStatusSpecified {
      get { return this.experimentDeltaStatusFieldSpecified; }
      set { this.experimentDeltaStatusFieldSpecified = value; }
    }

    public ExperimentDataStatus experimentDataStatus {
      get { return this.experimentDataStatusField; }
      set {
        this.experimentDataStatusField = value;
        this.experimentDataStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDataStatusSpecified {
      get { return this.experimentDataStatusFieldSpecified; }
      set { this.experimentDataStatusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ExperimentDeltaStatus {
    EXPERIMENT_ONLY,
    MODIFIED,
    CONTROL_ONLY,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ExperimentDataStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupAd.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupAdStatus {
    ENABLED,
    PAUSED,
    DISABLED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupAd.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupAdApprovalStatus {
    APPROVED,
    DISAPPROVED,
    FAMILY_SAFE,
    NON_FAMILY_SAFE,
    PORN,
    UNCHECKED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionPolicyError))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdParamPolicyError))]
  public partial class PolicyViolationError : ApiError {
    private PolicyViolationKey keyField;

    private string externalPolicyNameField;

    private string externalPolicyUrlField;

    private string externalPolicyDescriptionField;

    private bool isExemptableField;

    private bool isExemptableFieldSpecified;

    private PolicyViolationErrorPart[] violatingPartsField;

    public PolicyViolationKey key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }

    public string externalPolicyName {
      get { return this.externalPolicyNameField; }
      set { this.externalPolicyNameField = value; }
    }

    public string externalPolicyUrl {
      get { return this.externalPolicyUrlField; }
      set { this.externalPolicyUrlField = value; }
    }

    public string externalPolicyDescription {
      get { return this.externalPolicyDescriptionField; }
      set { this.externalPolicyDescriptionField = value; }
    }

    public bool isExemptable {
      get { return this.isExemptableField; }
      set {
        this.isExemptableField = value;
        this.isExemptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isExemptableSpecified {
      get { return this.isExemptableFieldSpecified; }
      set { this.isExemptableFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("violatingParts")]
    public PolicyViolationErrorPart[] violatingParts {
      get { return this.violatingPartsField; }
      set { this.violatingPartsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class PolicyViolationKey {
    private string policyNameField;

    private string violatingTextField;

    public string policyName {
      get { return this.policyNameField; }
      set { this.policyNameField = value; }
    }

    public string violatingText {
      get { return this.violatingTextField; }
      set { this.violatingTextField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PolicyViolationError.Part", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class PolicyViolationErrorPart {
    private int indexField;

    private bool indexFieldSpecified;

    private int lengthField;

    private bool lengthFieldSpecified;

    public int index {
      get { return this.indexField; }
      set {
        this.indexField = value;
        this.indexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool indexSpecified {
      get { return this.indexFieldSpecified; }
      set { this.indexFieldSpecified = value; }
    }

    public int length {
      get { return this.lengthField; }
      set {
        this.lengthField = value;
        this.lengthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool lengthSpecified {
      get { return this.lengthFieldSpecified; }
      set { this.lengthFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MediaError : ApiError {
    private MediaErrorReason reasonField;

    private bool reasonFieldSpecified;

    public MediaErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MediaError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MediaErrorReason {
    CANNOT_ADD_STANDARD_ICON,
    CANNOT_SELECT_STANDARD_ICON_WITH_OTHER_TYPES,
    DUPLICATE_MEDIA,
    EMPTY_FIELD,
    ENTITY_REFERENCED_IN_MULTIPLE_OPS,
    FIELD_NOT_SUPPORTED_FOR_MEDIA_SUB_TYPE,
    INVALID_MEDIA_ID,
    INVALID_MEDIA_TYPE,
    INVALID_MEDIA_SUB_TYPE,
    INVALID_REFERENCE_ID,
    INVALID_YOU_TUBE_ID,
    YOU_TUBE_VIDEO_NOT_FOUND,
    YOU_TUBE_SERVICE_UNAVAILABLE,
    YOU_TUBE_VIDEO_HAS_NON_POSITIVE_DURATION,
    MEDIA_FAILED_TRANSCODING,
    MEDIA_NOT_TRANSCODED,
    MEDIA_TYPE_DOES_NOT_MATCH_OBJECT_TYPE,
    NO_FIELDS_SPECIFIED,
    NULL_REFERENCE_ID_AND_MEDIA_ID,
    TOO_LONG,
    UNSUPPORTED_OPERATION,
    UNSUPPORTED_TYPE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ImageError : ApiError {
    private ImageErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ImageErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ImageError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ImageErrorReason {
    INVALID_IMAGE,
    STORAGE_ERROR,
    BAD_REQUEST,
    UNEXPECTED_SIZE,
    ANIMATED_NOT_ALLOWED,
    ANIMATION_TOO_LONG,
    SERVER_ERROR,
    CMYK_JPEG_NOT_ALLOWED,
    FLASH_NOT_ALLOWED,
    FLASH_WITHOUT_CLICKTAG,
    FLASH_ERROR_AFTER_FIXING_CLICK_TAG,
    ANIMATED_VISUAL_EFFECT,
    FLASH_ERROR,
    LAYOUT_PROBLEM,
    PROBLEM_READING_IMAGE_FILE,
    ERROR_STORING_IMAGE,
    FLASH_HAS_NETWORK_OBJECTS,
    FLASH_HAS_NETWORK_METHODS,
    FLASH_HAS_URL,
    FLASH_HAS_MOUSE_TRACKING,
    FLASH_HAS_RANDOM_NUM,
    FLASH_SELF_TARGETS,
    FLASH_BAD_GETURL_TARGET,
    FLASH_VERSION_NOT_SUPPORTED,
    FLASH_WITHOUT_HARD_CODED_CLICK_URL,
    INVALID_FLASH_FILE,
    FAILED_TO_FIX_CLICK_TAG_IN_FLASH,
    FLASH_ACCESSES_NETWORK_RESOURCES,
    FLASH_EXTERNAL_JS_CALL,
    FLASH_EXTERNAL_FS_CALL,
    FILE_TOO_LARGE,
    IMAGE_DATA_TOO_LARGE,
    IMAGE_PROCESSING_ERROR,
    IMAGE_TOO_SMALL,
    INVALID_INPUT,
    PROBLEM_READING_FILE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FunctionParsingError : ApiError {
    private FunctionParsingErrorReason reasonField;

    private bool reasonFieldSpecified;

    private string offendingTextField;

    private int offendingTextIndexField;

    private bool offendingTextIndexFieldSpecified;

    public FunctionParsingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public string offendingText {
      get { return this.offendingTextField; }
      set { this.offendingTextField = value; }
    }

    public int offendingTextIndex {
      get { return this.offendingTextIndexField; }
      set {
        this.offendingTextIndexField = value;
        this.offendingTextIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool offendingTextIndexSpecified {
      get { return this.offendingTextIndexFieldSpecified; }
      set { this.offendingTextIndexFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FunctionParsingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FunctionParsingErrorReason {
    NO_MORE_INPUT,
    EXPECTED_CHARACTER,
    UNEXPECTED_SEPARATOR,
    UNMATCHED_LEFT_BRACKET,
    UNMATCHED_RIGHT_BRACKET,
    TOO_MANY_NESTED_FUNCTIONS,
    MISSING_RIGHT_HAND_OPERAND,
    INVALID_OPERATOR_NAME,
    FEED_ATTRIBUTE_OPERAND_ARGUMENT_NOT_INTEGER,
    NO_OPERANDS,
    TOO_MANY_OPERANDS,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExperimentError : ApiError {
    private ExperimentErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ExperimentErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ExperimentError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ExperimentErrorReason {
    EXPERIMENT_DELTA_STATUS_NOT_SPECIFIED,
    EXPERIMENT_DELTA_STATUS_NOT_ALLOWED,
    EXPERIMENT_STATUS_NOT_ALLOWED,
    EXPERIMENT_NOT_ALLOWED_FOR_BIDDING_STRATEGY,
    EXPERIMENT_NOT_ALLOWED_FOR_CRITERION_TYPE,
    EXPERIMENT_NOT_ACTIVE,
    INVALID_EXPERIMENT_ID,
    EXPERIMENT_ID_NOT_SPECIFIED_WITH_SEGMENTATION_CRITERIA,
    TOO_MANY_CHANGES_TO_EXPERIMENT,
    EXPERIMENT_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdCountLimitExceeded : EntityCountLimitExceeded {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdError : ApiError {
    private AdGroupAdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupAdErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupAdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupAdErrorReason {
    AD_GROUP_AD_LABEL_DOES_NOT_EXIST,
    AD_GROUP_AD_LABEL_ALREADY_EXISTS,
    AD_NOT_UNDER_ADGROUP,
    CANNOT_OPERATE_ON_REMOVED_ADGROUPAD,
    CANNOT_CREATE_DEPRECATED_ADS,
    EMPTY_FIELD,
    ENTITY_REFERENCED_IN_MULTIPLE_OPS,
    UNSUPPORTED_OPERATION
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdError : ApiError {
    private AdErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdErrorReason {
    AD_CUSTOMIZERS_NOT_SUPPORTED_FOR_AD_TYPE,
    APPROXIMATELY_TOO_LONG,
    APPROXIMATELY_TOO_SHORT,
    BAD_SNIPPET,
    CANNOT_SET_BUSINESS_NAME_IF_URL_SET,
    CANNOT_SET_FIELD_WITH_ORIGIN_AD_ID_SET,
    CANNOT_SET_URL,
    CANNOT_SET_WITHOUT_FINAL_URLS,
    CANNOT_SET_WITH_FINAL_URLS,
    CANNOT_SET_WITH_TRACKING_URL_TEMPLATE,
    CUSTOMER_NOT_APPROVED_MOBILEADS,
    CUSTOMER_NOT_APPROVED_THIRDPARTY_ADS,
    CUSTOMER_NOT_APPROVED_THIRDPARTY_REDIRECT_ADS,
    CUSTOMER_NOT_ELIGIBLE,
    CUSTOMER_NOT_ELIGIBLE_FOR_UPDATING_BEACON_URL,
    DIMENSION_ALREADY_IN_UNION,
    DIMENSION_MUST_BE_SET,
    DIMENSION_NOT_IN_UNION,
    DISPLAY_URL_CANNOT_BE_SPECIFIED,
    DOMESTIC_PHONE_NUMBER_FORMAT,
    EMERGENCY_PHONE_NUMBER,
    EMPTY_FIELD,
    FEED_ATTRIBUTE_MUST_HAVE_MAPPING_FOR_TYPE_ID,
    FEED_ATTRIBUTE_MAPPING_TYPE_MISMATCH,
    ILLEGAL_AD_CUSTOMIZER_TAG_USE,
    INCONSISTENT_STATUS_IN_TEMPLATE_UNION,
    INCORRECT_LENGTH,
    INELIGIBLE_FOR_UPGRADE,
    INVALID_AD_ADDRESS_CAMPAIGN_TARGET,
    INVALID_AD_TYPE,
    INVALID_ATTRIBUTES_FOR_MOBILE_IMAGE,
    INVALID_ATTRIBUTES_FOR_MOBILE_TEXT,
    INVALID_CHARACTER_FOR_URL,
    INVALID_COUNTRY_CODE,
    INVALID_DSA_URL_TAG,
    INVALID_INPUT,
    INVALID_MARKUP_LANGUAGE,
    INVALID_MOBILE_CARRIER,
    INVALID_MOBILE_CARRIER_TARGET,
    INVALID_NUMBER_OF_ELEMENTS,
    INVALID_PHONE_NUMBER_FORMAT,
    INVALID_RICH_MEDIA_CERTIFIED_VENDOR_FORMAT_ID,
    INVALID_TEMPLATE_DATA,
    INVALID_TEMPLATE_ELEMENT_FIELD_TYPE,
    INVALID_TEMPLATE_ID,
    LINE_TOO_WIDE,
    MARKUP_LANGUAGES_PRESENT,
    MISSING_AD_CUSTOMIZER_MAPPING,
    MISSING_ADDRESS_COMPONENT,
    MISSING_ADVERTISEMENT_NAME,
    MISSING_BUSINESS_NAME,
    MISSING_DESCRIPTION1,
    MISSING_DESCRIPTION2,
    MISSING_DESTINATION_URL,
    MISSING_DESTINATION_URL_TAG,
    MISSING_DIMENSION,
    MISSING_DISPLAY_URL,
    MISSING_HEADLINE,
    MISSING_HEIGHT,
    MISSING_IMAGE,
    MISSING_MARKUP_LANGUAGES,
    MISSING_MOBILE_CARRIER,
    MISSING_PHONE,
    MISSING_REQUIRED_TEMPLATE_FIELDS,
    MISSING_TEMPLATE_FIELD_VALUE,
    MISSING_TEXT,
    MISSING_URL_AND_PHONE,
    MISSING_VISIBLE_URL,
    MISSING_WIDTH,
    MULTIPLE_DISTINCT_FEEDS_UNSUPPORTED,
    MUST_USE_TEMP_AD_UNION_ID_ON_ADD,
    TOO_LONG,
    TOO_SHORT,
    UNION_DIMENSIONS_CANNOT_CHANGE,
    UNKNOWN_ADDRESS_COMPONENT,
    UNKNOWN_FIELD_NAME,
    UNKNOWN_UNIQUE_NAME,
    UNSUPPORTED_DIMENSIONS,
    URL_INVALID_SCHEME,
    URL_INVALID_TOP_LEVEL_DOMAIN,
    URL_MALFORMED,
    URL_NO_HOST,
    URL_NOT_EQUIVALENT,
    URL_HOST_NAME_TOO_LONG,
    URL_NO_SCHEME,
    URL_NO_TOP_LEVEL_DOMAIN,
    URL_PATH_NOT_ALLOWED,
    URL_PORT_NOT_ALLOWED,
    URL_QUERY_NOT_ALLOWED,
    URL_SCHEME_BEFORE_DSA_TAG,
    USER_DOES_NOT_HAVE_ACCESS_TO_TEMPLATE,
    INCONSISTENT_EXPANDABLE_SETTINGS,
    INVALID_FORMAT,
    INVALID_FIELD_TEXT,
    ELEMENT_NOT_PRESENT,
    IMAGE_ERROR,
    VALUE_NOT_IN_RANGE,
    FIELD_NOT_PRESENT,
    ADDRESS_NOT_COMPLETE,
    ADDRESS_INVALID,
    VIDEO_RETRIEVAL_ERROR,
    AUDIO_ERROR,
    INVALID_YOUTUBE_DISPLAY_URL,
    INCOMPATIBLE_AD_TYPE_AND_DEVICE_PREFERENCE,
    CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY,
    CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED,
    DISALLOWED_NUMBER_TYPE,
    PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY,
    PREMIUM_RATE_NUMBER_NOT_ALLOWED,
    VANITY_PHONE_NUMBER_NOT_ALLOWED,
    INVALID_CALL_CONVERSION_TYPE_ID
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdLabelReturnValue : ListReturnValue {
    private AdGroupAdLabel[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupAdLabel[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdLabel {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private long adIdField;

    private bool adIdFieldSpecified;

    private long labelIdField;

    private bool labelIdFieldSpecified;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public long adId {
      get { return this.adIdField; }
      set {
        this.adIdField = value;
        this.adIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adIdSpecified {
      get { return this.adIdFieldSpecified; }
      set { this.adIdFieldSpecified = value; }
    }

    public long labelId {
      get { return this.labelIdField; }
      set {
        this.labelIdField = value;
        this.labelIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool labelIdSpecified {
      get { return this.labelIdFieldSpecified; }
      set { this.labelIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExemptionRequest {
    private PolicyViolationKey keyField;

    public PolicyViolationKey key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdOperation : Operation {
    private AdGroupAd operandField;

    private ExemptionRequest[] exemptionRequestsField;

    public AdGroupAd operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("exemptionRequests")]
    public ExemptionRequest[] exemptionRequests {
      get { return this.exemptionRequestsField; }
      set { this.exemptionRequestsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdLabelOperation : Operation {
    private AdGroupAdLabel operandField;

    public AdGroupAdLabel operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupAdPage : Page {
    private AdGroupAd[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupAd[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ExperimentServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ExperimentService : AdWordsSoapClient, IExperimentService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ExperimentService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/ExperimentService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ExperimentPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((ExperimentPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ExperimentReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
ExperimentOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((ExperimentReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExperimentReturnValue : ListReturnValue {
    private Experiment[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Experiment[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Experiment {
    private long idField;

    private bool idFieldSpecified;

    private long controlIdField;

    private bool controlIdFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string nameField;

    private ExperimentStatus statusField;

    private bool statusFieldSpecified;

    private ExperimentServingStatus servingStatusField;

    private bool servingStatusFieldSpecified;

    private int queryPercentageField;

    private bool queryPercentageFieldSpecified;

    private string startDateTimeField;

    private string endDateTimeField;

    private string lastModifiedDateTimeField;

    private ExperimentSummaryStats experimentSummaryStatsField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public long controlId {
      get { return this.controlIdField; }
      set {
        this.controlIdField = value;
        this.controlIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool controlIdSpecified {
      get { return this.controlIdFieldSpecified; }
      set { this.controlIdFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public ExperimentStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public ExperimentServingStatus servingStatus {
      get { return this.servingStatusField; }
      set {
        this.servingStatusField = value;
        this.servingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool servingStatusSpecified {
      get { return this.servingStatusFieldSpecified; }
      set { this.servingStatusFieldSpecified = value; }
    }

    public int queryPercentage {
      get { return this.queryPercentageField; }
      set {
        this.queryPercentageField = value;
        this.queryPercentageSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool queryPercentageSpecified {
      get { return this.queryPercentageFieldSpecified; }
      set { this.queryPercentageFieldSpecified = value; }
    }

    public string startDateTime {
      get { return this.startDateTimeField; }
      set { this.startDateTimeField = value; }
    }

    public string endDateTime {
      get { return this.endDateTimeField; }
      set { this.endDateTimeField = value; }
    }

    public string lastModifiedDateTime {
      get { return this.lastModifiedDateTimeField; }
      set { this.lastModifiedDateTimeField = value; }
    }

    public ExperimentSummaryStats experimentSummaryStats {
      get { return this.experimentSummaryStatsField; }
      set { this.experimentSummaryStatsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ExperimentStatus {
    ENABLED,
    REMOVED,
    PROMOTED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ExperimentServingStatus {
    RUNNING,
    PENDING,
    ENDED,
    REMOVED,
    PROMOTED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExperimentSummaryStats {
    private int adGroupsCountField;

    private bool adGroupsCountFieldSpecified;

    private int adGroupCriteriaCountField;

    private bool adGroupCriteriaCountFieldSpecified;

    private int adGroupAdsCountField;

    private bool adGroupAdsCountFieldSpecified;

    public int adGroupsCount {
      get { return this.adGroupsCountField; }
      set {
        this.adGroupsCountField = value;
        this.adGroupsCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupsCountSpecified {
      get { return this.adGroupsCountFieldSpecified; }
      set { this.adGroupsCountFieldSpecified = value; }
    }

    public int adGroupCriteriaCount {
      get { return this.adGroupCriteriaCountField; }
      set {
        this.adGroupCriteriaCountField = value;
        this.adGroupCriteriaCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupCriteriaCountSpecified {
      get { return this.adGroupCriteriaCountFieldSpecified; }
      set { this.adGroupCriteriaCountFieldSpecified = value; }
    }

    public int adGroupAdsCount {
      get { return this.adGroupAdsCountField; }
      set {
        this.adGroupAdsCountField = value;
        this.adGroupAdsCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupAdsCountSpecified {
      get { return this.adGroupAdsCountFieldSpecified; }
      set { this.adGroupAdsCountFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExperimentOperation : Operation {
    private Experiment operandField;

    public Experiment operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExperimentPage : Page {
    private Experiment[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Experiment[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExperimentServiceError : ApiError {
    private ExperimentServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ExperimentServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ExperimentServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ExperimentServiceErrorReason {
    AFTER_MAXIMUM_ALLOWABLE_DATE,
    AOL_PARTNER_CAMPAIGNS_CANT_RUN_EXPERIMENTS,
    CANNOT_CREATE_EXPERIMENT_FOR_BIDDING_STRATEGY,
    CANNOT_CREATE_EXPERIMENT_FOR_BIDDING_STRATEGY_FEATURE,
    CANNOT_SET_DATE_TO_PAST,
    CANNOT_SET_END_DATE_WITHOUT_SETTING_START_DATE,
    CANNOT_USE_EXPERIMENT_WITH_SHARED_BUDGET,
    DATE_OUTSIDE_CAMPAIGN_DATE_RANGE,
    EXPERIMENT_ALREADY_STARTED,
    EXPERIMENT_ENDED,
    EXPERIMENT_LIMIT_EXCEEDED,
    INVALID_EXPERIMENT_NAME,
    INVALID_QUERY_PERCENTAGE,
    CANNOT_CHANGE_QUERY_PERCENTAGE_AFTER_EXPERIMENT_HAS_STARTED,
    INVALID_STATUS_UPDATE,
    START_DATE_AFTER_END_DATE,
    NO_VALID_BUDGET,
    EXPERIMENT_NOT_ACTIVE,
    EXPERIMENT_SERVICE_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "FeedServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class FeedService : AdWordsSoapClient, IFeedService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public FeedService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/FeedService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((FeedPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
FeedOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((FeedReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((FeedPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedReturnValue : ListReturnValue {
    private Feed[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Feed[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Feed {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private FeedAttribute[] attributesField;

    private FeedStatus statusField;

    private bool statusFieldSpecified;

    private FeedOrigin originField;

    private bool originFieldSpecified;

    private SystemFeedGenerationData systemFeedGenerationDataField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("attributes")]
    public FeedAttribute[] attributes {
      get { return this.attributesField; }
      set { this.attributesField = value; }
    }

    public FeedStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public FeedOrigin origin {
      get { return this.originField; }
      set {
        this.originField = value;
        this.originSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool originSpecified {
      get { return this.originFieldSpecified; }
      set { this.originFieldSpecified = value; }
    }

    public SystemFeedGenerationData systemFeedGenerationData {
      get { return this.systemFeedGenerationDataField; }
      set { this.systemFeedGenerationDataField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedAttribute {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private FeedAttributeType typeField;

    private bool typeFieldSpecified;

    private bool isPartOfKeyField;

    private bool isPartOfKeyFieldSpecified;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public FeedAttributeType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public bool isPartOfKey {
      get { return this.isPartOfKeyField; }
      set {
        this.isPartOfKeyField = value;
        this.isPartOfKeySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isPartOfKeySpecified {
      get { return this.isPartOfKeyFieldSpecified; }
      set { this.isPartOfKeyFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedAttribute.Type", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedAttributeType {
    INT64,
    FLOAT,
    STRING,
    BOOLEAN,
    URL,
    DATE_TIME,
    INT64_LIST,
    FLOAT_LIST,
    STRING_LIST,
    BOOLEAN_LIST,
    URL_LIST,
    DATE_TIME_LIST,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Feed.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Feed.Origin", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedOrigin {
    USER,
    ADWORDS,
    UNKNOWN
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacesLocationFeedData))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SystemFeedGenerationData {
    private string systemFeedGenerationDataTypeField;

    [System.Xml.Serialization.XmlElementAttribute("SystemFeedGenerationData.Type")]
    public string SystemFeedGenerationDataType {
      get { return this.systemFeedGenerationDataTypeField; }
      set { this.systemFeedGenerationDataTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class PlacesLocationFeedData : SystemFeedGenerationData {
    private OAuthInfo oAuthInfoField;

    private string emailAddressField;

    private string businessAccountIdentifierField;

    private string businessNameFilterField;

    private string[] categoryFiltersField;

    public OAuthInfo oAuthInfo {
      get { return this.oAuthInfoField; }
      set { this.oAuthInfoField = value; }
    }

    public string emailAddress {
      get { return this.emailAddressField; }
      set { this.emailAddressField = value; }
    }

    public string businessAccountIdentifier {
      get { return this.businessAccountIdentifierField; }
      set { this.businessAccountIdentifierField = value; }
    }

    public string businessNameFilter {
      get { return this.businessNameFilterField; }
      set { this.businessNameFilterField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("categoryFilters")]
    public string[] categoryFilters {
      get { return this.categoryFiltersField; }
      set { this.categoryFiltersField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedOperation : Operation {
    private Feed operandField;

    public Feed operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedPage : NullStatsPage {
    private Feed[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Feed[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedError : ApiError {
    private FeedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public FeedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedErrorReason {
    ATTRIBUTE_NAMES_NOT_UNIQUE,
    ATTRIBUTES_DO_NOT_MATCH_EXISTING_ATTRIBUTES,
    CANNOT_CHANGE_ORIGIN,
    CANNOT_SPECIFY_USER_ORIGIN_FOR_SYSTEM_FEED,
    CANNOT_SPECIFY_ADWORDS_ORIGIN_FOR_NON_SYSTEM_FEED,
    CANNOT_SPECIFY_FEED_ATTRIBUTES_FOR_SYSTEM_FEED,
    CANNOT_UPDATE_FEED_ATTRIBUTES_WITH_ORIGIN_ADWORDS,
    FEED_REMOVED,
    INVALID_ORIGIN_VALUE,
    FEED_ORIGIN_IS_NOT_USER,
    DUPLICATE_FEED_NAME,
    INVALID_FEED_NAME,
    MISSING_OAUTH_INFO,
    NEW_ATTRIBUTE_CANNOT_BE_PART_OF_UNIQUE_KEY,
    TOO_MANY_FEED_ATTRIBUTES_FOR_FEED,
    INVALID_BUSINESS_ACCOUNT,
    BUSINESS_ACCOUNT_CANNOT_ACCESS_LOCATION_ACCOUNT,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "FeedItemServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Criterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class FeedItemService : AdWordsSoapClient, IFeedItemService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public FeedItemService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/FeedItemService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedItemPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((FeedItemPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedItemReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
FeedItemOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((FeedItemReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedItemPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((FeedItemPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemReturnValue : ListReturnValue {
    private FeedItem[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public FeedItem[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItem {
    private long feedIdField;

    private bool feedIdFieldSpecified;

    private long feedItemIdField;

    private bool feedItemIdFieldSpecified;

    private FeedItemStatus statusField;

    private bool statusFieldSpecified;

    private string startTimeField;

    private string endTimeField;

    private FeedItemAttributeValue[] attributeValuesField;

    private FeedItemValidationDetail[] validationDetailsField;

    private FeedItemDevicePreference devicePreferenceField;

    private FeedItemSchedule[] schedulingField;

    private FeedItemCampaignTargeting campaignTargetingField;

    private FeedItemAdGroupTargeting adGroupTargetingField;

    private Keyword keywordTargetingField;

    private CustomParameters urlCustomParametersField;

    public long feedId {
      get { return this.feedIdField; }
      set {
        this.feedIdField = value;
        this.feedIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedIdSpecified {
      get { return this.feedIdFieldSpecified; }
      set { this.feedIdFieldSpecified = value; }
    }

    public long feedItemId {
      get { return this.feedItemIdField; }
      set {
        this.feedItemIdField = value;
        this.feedItemIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedItemIdSpecified {
      get { return this.feedItemIdFieldSpecified; }
      set { this.feedItemIdFieldSpecified = value; }
    }

    public FeedItemStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public string startTime {
      get { return this.startTimeField; }
      set { this.startTimeField = value; }
    }

    public string endTime {
      get { return this.endTimeField; }
      set { this.endTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("attributeValues")]
    public FeedItemAttributeValue[] attributeValues {
      get { return this.attributeValuesField; }
      set { this.attributeValuesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("validationDetails")]
    public FeedItemValidationDetail[] validationDetails {
      get { return this.validationDetailsField; }
      set { this.validationDetailsField = value; }
    }

    public FeedItemDevicePreference devicePreference {
      get { return this.devicePreferenceField; }
      set { this.devicePreferenceField = value; }
    }

    [System.Xml.Serialization.XmlArrayItemAttribute("feedItemSchedules", IsNullable = false)]
    public FeedItemSchedule[] scheduling {
      get { return this.schedulingField; }
      set { this.schedulingField = value; }
    }

    public FeedItemCampaignTargeting campaignTargeting {
      get { return this.campaignTargetingField; }
      set { this.campaignTargetingField = value; }
    }

    public FeedItemAdGroupTargeting adGroupTargeting {
      get { return this.adGroupTargetingField; }
      set { this.adGroupTargetingField = value; }
    }

    public Keyword keywordTargeting {
      get { return this.keywordTargetingField; }
      set { this.keywordTargetingField = value; }
    }

    public CustomParameters urlCustomParameters {
      get { return this.urlCustomParametersField; }
      set { this.urlCustomParametersField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedItem.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedItemStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemAttributeValue {
    private long feedAttributeIdField;

    private bool feedAttributeIdFieldSpecified;

    private long integerValueField;

    private bool integerValueFieldSpecified;

    private double doubleValueField;

    private bool doubleValueFieldSpecified;

    private bool booleanValueField;

    private bool booleanValueFieldSpecified;

    private string stringValueField;

    private long[] integerValuesField;

    private double[] doubleValuesField;

    private bool[] booleanValuesField;

    private string[] stringValuesField;

    public long feedAttributeId {
      get { return this.feedAttributeIdField; }
      set {
        this.feedAttributeIdField = value;
        this.feedAttributeIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedAttributeIdSpecified {
      get { return this.feedAttributeIdFieldSpecified; }
      set { this.feedAttributeIdFieldSpecified = value; }
    }

    public long integerValue {
      get { return this.integerValueField; }
      set {
        this.integerValueField = value;
        this.integerValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool integerValueSpecified {
      get { return this.integerValueFieldSpecified; }
      set { this.integerValueFieldSpecified = value; }
    }

    public double doubleValue {
      get { return this.doubleValueField; }
      set {
        this.doubleValueField = value;
        this.doubleValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool doubleValueSpecified {
      get { return this.doubleValueFieldSpecified; }
      set { this.doubleValueFieldSpecified = value; }
    }

    public bool booleanValue {
      get { return this.booleanValueField; }
      set {
        this.booleanValueField = value;
        this.booleanValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool booleanValueSpecified {
      get { return this.booleanValueFieldSpecified; }
      set { this.booleanValueFieldSpecified = value; }
    }

    public string stringValue {
      get { return this.stringValueField; }
      set { this.stringValueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("integerValues")]
    public long[] integerValues {
      get { return this.integerValuesField; }
      set { this.integerValuesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("doubleValues")]
    public double[] doubleValues {
      get { return this.doubleValuesField; }
      set { this.doubleValuesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("booleanValues")]
    public bool[] booleanValues {
      get { return this.booleanValuesField; }
      set { this.booleanValuesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("stringValues")]
    public string[] stringValues {
      get { return this.stringValuesField; }
      set { this.stringValuesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemValidationDetail {
    private long feedMappingIdField;

    private bool feedMappingIdFieldSpecified;

    private FeedItemValidationDetailValidationStatus validationStatusField;

    private bool validationStatusFieldSpecified;

    private FeedItemAttributeError[] validationErrorsField;

    private FeedItemValidationDetailApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    public long feedMappingId {
      get { return this.feedMappingIdField; }
      set {
        this.feedMappingIdField = value;
        this.feedMappingIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedMappingIdSpecified {
      get { return this.feedMappingIdFieldSpecified; }
      set { this.feedMappingIdFieldSpecified = value; }
    }

    public FeedItemValidationDetailValidationStatus validationStatus {
      get { return this.validationStatusField; }
      set {
        this.validationStatusField = value;
        this.validationStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool validationStatusSpecified {
      get { return this.validationStatusFieldSpecified; }
      set { this.validationStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("validationErrors")]
    public FeedItemAttributeError[] validationErrors {
      get { return this.validationErrorsField; }
      set { this.validationErrorsField = value; }
    }

    public FeedItemValidationDetailApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedItemValidationDetail.ValidationStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedItemValidationDetailValidationStatus {
    ERROR,
    UNCHECKED,
    VALID
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemAttributeError {
    private long[] feedAttributeIdsField;

    private int validationErrorCodeField;

    private bool validationErrorCodeFieldSpecified;

    private string errorInformationField;

    [System.Xml.Serialization.XmlElementAttribute("feedAttributeIds")]
    public long[] feedAttributeIds {
      get { return this.feedAttributeIdsField; }
      set { this.feedAttributeIdsField = value; }
    }

    public int validationErrorCode {
      get { return this.validationErrorCodeField; }
      set {
        this.validationErrorCodeField = value;
        this.validationErrorCodeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool validationErrorCodeSpecified {
      get { return this.validationErrorCodeFieldSpecified; }
      set { this.validationErrorCodeFieldSpecified = value; }
    }

    public string errorInformation {
      get { return this.errorInformationField; }
      set { this.errorInformationField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedItemValidationDetail.ApprovalStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedItemValidationDetailApprovalStatus {
    APPROVED,
    DISAPPROVED,
    UNCHECKED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemDevicePreference {
    private long devicePreferenceField;

    private bool devicePreferenceFieldSpecified;

    public long devicePreference {
      get { return this.devicePreferenceField; }
      set {
        this.devicePreferenceField = value;
        this.devicePreferenceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool devicePreferenceSpecified {
      get { return this.devicePreferenceFieldSpecified; }
      set { this.devicePreferenceFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemSchedule {
    private DayOfWeek dayOfWeekField;

    private bool dayOfWeekFieldSpecified;

    private int startHourField;

    private bool startHourFieldSpecified;

    private MinuteOfHour startMinuteField;

    private bool startMinuteFieldSpecified;

    private int endHourField;

    private bool endHourFieldSpecified;

    private MinuteOfHour endMinuteField;

    private bool endMinuteFieldSpecified;

    public DayOfWeek dayOfWeek {
      get { return this.dayOfWeekField; }
      set {
        this.dayOfWeekField = value;
        this.dayOfWeekSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool dayOfWeekSpecified {
      get { return this.dayOfWeekFieldSpecified; }
      set { this.dayOfWeekFieldSpecified = value; }
    }

    public int startHour {
      get { return this.startHourField; }
      set {
        this.startHourField = value;
        this.startHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startHourSpecified {
      get { return this.startHourFieldSpecified; }
      set { this.startHourFieldSpecified = value; }
    }

    public MinuteOfHour startMinute {
      get { return this.startMinuteField; }
      set {
        this.startMinuteField = value;
        this.startMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startMinuteSpecified {
      get { return this.startMinuteFieldSpecified; }
      set { this.startMinuteFieldSpecified = value; }
    }

    public int endHour {
      get { return this.endHourField; }
      set {
        this.endHourField = value;
        this.endHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endHourSpecified {
      get { return this.endHourFieldSpecified; }
      set { this.endHourFieldSpecified = value; }
    }

    public MinuteOfHour endMinute {
      get { return this.endMinuteField; }
      set {
        this.endMinuteField = value;
        this.endMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endMinuteSpecified {
      get { return this.endMinuteFieldSpecified; }
      set { this.endMinuteFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemCampaignTargeting {
    private long targetingCampaignIdField;

    private bool targetingCampaignIdFieldSpecified;

    public long TargetingCampaignId {
      get { return this.targetingCampaignIdField; }
      set {
        this.targetingCampaignIdField = value;
        this.TargetingCampaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool TargetingCampaignIdSpecified {
      get { return this.targetingCampaignIdFieldSpecified; }
      set { this.targetingCampaignIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemAdGroupTargeting {
    private long targetingAdGroupIdField;

    private bool targetingAdGroupIdFieldSpecified;

    public long TargetingAdGroupId {
      get { return this.targetingAdGroupIdField; }
      set {
        this.targetingAdGroupIdField = value;
        this.TargetingAdGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool TargetingAdGroupIdSpecified {
      get { return this.targetingAdGroupIdFieldSpecified; }
      set { this.targetingAdGroupIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemError : ApiError {
    private FeedItemErrorReason reasonField;

    private bool reasonFieldSpecified;

    public FeedItemErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedItemError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedItemErrorReason {
    CAMPAIGN_TARGETING_MISMATCH,
    CANNOT_CONVERT_ATTRIBUTE_VALUE_FROM_STRING,
    CANNOT_OPERATE_ON_REMOVED_FEED_ITEM,
    DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE,
    KEY_ATTRIBUTES_NOT_FOUND,
    INVALID_DEVICE_PREFERENCE,
    INVALID_SCHEDULE_END,
    INVALID_URL,
    MISSING_KEY_ATTRIBUTES,
    KEY_ATTRIBUTES_NOT_UNIQUE,
    CANNOT_MODIFY_KEY_ATTRIBUTE_VALUE,
    OVERLAPPING_SCHEDULES,
    SCHEDULE_END_NOT_AFTER_START,
    TOO_MANY_SCHEDULES_PER_DAY,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemOperation : Operation {
    private FeedItem operandField;

    public FeedItem operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedItemPage : NullStatsPage {
    private FeedItem[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public FeedItem[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "FeedMappingServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class FeedMappingService : AdWordsSoapClient, IFeedMappingService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public FeedMappingService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/FeedMappingService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedMappingPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((FeedMappingPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedMappingReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
FeedMappingOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((FeedMappingReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual FeedMappingPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((FeedMappingPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedMappingReturnValue : ListReturnValue {
    private FeedMapping[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public FeedMapping[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedMapping {
    private long feedMappingIdField;

    private bool feedMappingIdFieldSpecified;

    private long feedIdField;

    private bool feedIdFieldSpecified;

    private int placeholderTypeField;

    private bool placeholderTypeFieldSpecified;

    private FeedMappingStatus statusField;

    private bool statusFieldSpecified;

    private AttributeFieldMapping[] attributeFieldMappingsField;

    private int criterionTypeField;

    private bool criterionTypeFieldSpecified;

    public long feedMappingId {
      get { return this.feedMappingIdField; }
      set {
        this.feedMappingIdField = value;
        this.feedMappingIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedMappingIdSpecified {
      get { return this.feedMappingIdFieldSpecified; }
      set { this.feedMappingIdFieldSpecified = value; }
    }

    public long feedId {
      get { return this.feedIdField; }
      set {
        this.feedIdField = value;
        this.feedIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedIdSpecified {
      get { return this.feedIdFieldSpecified; }
      set { this.feedIdFieldSpecified = value; }
    }

    public int placeholderType {
      get { return this.placeholderTypeField; }
      set {
        this.placeholderTypeField = value;
        this.placeholderTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool placeholderTypeSpecified {
      get { return this.placeholderTypeFieldSpecified; }
      set { this.placeholderTypeFieldSpecified = value; }
    }

    public FeedMappingStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("attributeFieldMappings")]
    public AttributeFieldMapping[] attributeFieldMappings {
      get { return this.attributeFieldMappingsField; }
      set { this.attributeFieldMappingsField = value; }
    }

    public int criterionType {
      get { return this.criterionTypeField; }
      set {
        this.criterionTypeField = value;
        this.criterionTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionTypeSpecified {
      get { return this.criterionTypeFieldSpecified; }
      set { this.criterionTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedMapping.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedMappingStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AttributeFieldMapping {
    private long feedAttributeIdField;

    private bool feedAttributeIdFieldSpecified;

    private int fieldIdField;

    private bool fieldIdFieldSpecified;

    public long feedAttributeId {
      get { return this.feedAttributeIdField; }
      set {
        this.feedAttributeIdField = value;
        this.feedAttributeIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedAttributeIdSpecified {
      get { return this.feedAttributeIdFieldSpecified; }
      set { this.feedAttributeIdFieldSpecified = value; }
    }

    public int fieldId {
      get { return this.fieldIdField; }
      set {
        this.fieldIdField = value;
        this.fieldIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool fieldIdSpecified {
      get { return this.fieldIdFieldSpecified; }
      set { this.fieldIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedMappingOperation : Operation {
    private FeedMapping operandField;

    public FeedMapping operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedMappingPage : NullStatsPage {
    private FeedMapping[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public FeedMapping[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class FeedMappingError : ApiError {
    private FeedMappingErrorReason reasonField;

    private bool reasonFieldSpecified;

    public FeedMappingErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "FeedMappingError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum FeedMappingErrorReason {
    INVALID_PLACEHOLDER_FIELD,
    INVALID_CRITERION_FIELD,
    INVALID_PLACEHOLDER_TYPE,
    INVALID_CRITERION_TYPE,
    CANNOT_SET_PLACEHOLDER_TYPE_AND_CRITERION_TYPE,
    NO_ATTRIBUTE_FIELD_MAPPINGS,
    FEED_ATTRIBUTE_TYPE_MISMATCH,
    CANNOT_OPERATE_ON_MAPPINGS_FOR_SYSTEM_GENERATED_FEED,
    MULTIPLE_MAPPINGS_FOR_PLACEHOLDER_TYPE,
    MULTIPLE_MAPPINGS_FOR_CRITERION_TYPE,
    UNEXPECTED_ATTRIBUTE_FIELD_MAPPINGS,
    LOCATION_PLACEHOLDER_ONLY_FOR_PLACES_FEEDS,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "GeoLocationServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class GeoLocationService : AdWordsSoapClient, IGeoLocationService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public GeoLocationService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/GeoLocationService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual GeoLocation[] get(GeoLocationSelector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((GeoLocation[]) (results[0]));
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InvalidGeoLocation))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class GeoLocation {
    private GeoPoint geoPointField;

    private Address addressField;

    private byte[] encodedLocationField;

    private string geoLocationTypeField;

    public GeoPoint geoPoint {
      get { return this.geoPointField; }
      set { this.geoPointField = value; }
    }

    public Address address {
      get { return this.addressField; }
      set { this.addressField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
    public byte[] encodedLocation {
      get { return this.encodedLocationField; }
      set { this.encodedLocationField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("GeoLocation.Type")]
    public string GeoLocationType {
      get { return this.geoLocationTypeField; }
      set { this.geoLocationTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class InvalidGeoLocation : GeoLocation {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class GeoLocationSelector {
    private Address[] addressesField;


    [System.Xml.Serialization.XmlElementAttribute("addresses")]
    public Address[] addresses {
      get { return this.addressesField; }
      set { this.addressesField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class GeoLocationError : ApiError {
    private GeoLocationErrorReason reasonField;

    private bool reasonFieldSpecified;

    public GeoLocationErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "GeoLocationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum GeoLocationErrorReason {
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "LocationCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Criterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class LocationCriterionService : AdWordsSoapClient, ILocationCriterionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public LocationCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/LocationCriterionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual LocationCriterion[] get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((LocationCriterion[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual LocationCriterion[] query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((LocationCriterion[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LocationCriterion {
    private Location locationField;

    private string canonicalNameField;

    private long reachField;

    private bool reachFieldSpecified;

    private string localeField;

    private string searchTermField;

    private string countryCodeField;

    public Location location {
      get { return this.locationField; }
      set { this.locationField = value; }
    }

    public string canonicalName {
      get { return this.canonicalNameField; }
      set { this.canonicalNameField = value; }
    }

    public long reach {
      get { return this.reachField; }
      set {
        this.reachField = value;
        this.reachSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reachSpecified {
      get { return this.reachFieldSpecified; }
      set { this.reachFieldSpecified = value; }
    }

    public string locale {
      get { return this.localeField; }
      set { this.localeField = value; }
    }

    public string searchTerm {
      get { return this.searchTermField; }
      set { this.searchTermField = value; }
    }

    public string countryCode {
      get { return this.countryCodeField; }
      set { this.countryCodeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Date {
    private int yearField;

    private bool yearFieldSpecified;

    private int monthField;

    private bool monthFieldSpecified;

    private int dayField;

    private bool dayFieldSpecified;

    public int year {
      get { return this.yearField; }
      set {
        this.yearField = value;
        this.yearSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool yearSpecified {
      get { return this.yearFieldSpecified; }
      set { this.yearFieldSpecified = value; }
    }

    public int month {
      get { return this.monthField; }
      set {
        this.monthField = value;
        this.monthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool monthSpecified {
      get { return this.monthFieldSpecified; }
      set { this.monthFieldSpecified = value; }
    }

    public int day {
      get { return this.dayField; }
      set {
        this.dayField = value;
        this.daySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool daySpecified {
      get { return this.dayFieldSpecified; }
      set { this.dayFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LocationCriterionServiceError : ApiError {
    private LocationCriterionServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    public LocationCriterionServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LocationCriterionServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum LocationCriterionServiceErrorReason {
    REQUIRED_LOCATION_CRITERION_PREDICATE_MISSING,
    TOO_MANY_LOCATION_CRITERION_PREDICATES_SPECIFIED,
    INVALID_COUNTRY_CODE,
    LOCATION_CRITERION_SERVICE_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ManagedCustomerServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ManagedCustomerService : AdWordsSoapClient, IManagedCustomerService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ManagedCustomerService() {
      this.Url = "https://adwords.google.com/api/adwords/mcm/v201409/ManagedCustomerService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ManagedCustomerPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((ManagedCustomerPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual PendingInvitation[] getPendingInvitations(PendingInvitationSelector selector) {
      object[] results = this.Invoke("getPendingInvitations", new object[] { selector });
      return ((PendingInvitation[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ManagedCustomerReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
ManagedCustomerOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((ManagedCustomerReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlArrayAttribute("rval")]
    [return: System.Xml.Serialization.XmlArrayItemAttribute("links", IsNullable = false)]
    public virtual ManagedCustomerLink[] mutateLink([System.Xml.Serialization.XmlElementAttribute("operations")]
LinkOperation[] operations) {
      object[] results = this.Invoke("mutateLink", new object[] { operations });
      return ((ManagedCustomerLink[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/mcm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlArrayAttribute("rval")]
    [return: System.Xml.Serialization.XmlArrayItemAttribute("links", IsNullable = false)]
    public virtual ManagedCustomerLink[] mutateManager([System.Xml.Serialization.XmlElementAttribute("operations")]
MoveOperation[] operations) {
      object[] results = this.Invoke("mutateManager", new object[] { operations });
      return ((ManagedCustomerLink[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class ManagedCustomerReturnValue {
    private ManagedCustomer[] valueField;


    [System.Xml.Serialization.XmlElementAttribute("value")]
    public ManagedCustomer[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class ManagedCustomer {
    private string nameField;

    private string companyNameField;

    private long customerIdField;

    private bool customerIdFieldSpecified;

    private bool canManageClientsField;

    private bool canManageClientsFieldSpecified;

    private string currencyCodeField;

    private string dateTimeZoneField;

    private bool testAccountField;

    private bool testAccountFieldSpecified;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public string companyName {
      get { return this.companyNameField; }
      set { this.companyNameField = value; }
    }

    public long customerId {
      get { return this.customerIdField; }
      set {
        this.customerIdField = value;
        this.customerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool customerIdSpecified {
      get { return this.customerIdFieldSpecified; }
      set { this.customerIdFieldSpecified = value; }
    }

    public bool canManageClients {
      get { return this.canManageClientsField; }
      set {
        this.canManageClientsField = value;
        this.canManageClientsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool canManageClientsSpecified {
      get { return this.canManageClientsFieldSpecified; }
      set { this.canManageClientsFieldSpecified = value; }
    }

    public string currencyCode {
      get { return this.currencyCodeField; }
      set { this.currencyCodeField = value; }
    }

    public string dateTimeZone {
      get { return this.dateTimeZoneField; }
      set { this.dateTimeZoneField = value; }
    }

    public bool testAccount {
      get { return this.testAccountField; }
      set {
        this.testAccountField = value;
        this.testAccountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool testAccountSpecified {
      get { return this.testAccountFieldSpecified; }
      set { this.testAccountFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class ManagedCustomerOperation : Operation {
    private ManagedCustomer operandField;

    public ManagedCustomer operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class MoveOperation : Operation {
    private ManagedCustomerLink operandField;

    private long oldManagerCustomerIdField;

    private bool oldManagerCustomerIdFieldSpecified;

    public ManagedCustomerLink operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }

    public long oldManagerCustomerId {
      get { return this.oldManagerCustomerIdField; }
      set {
        this.oldManagerCustomerIdField = value;
        this.oldManagerCustomerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool oldManagerCustomerIdSpecified {
      get { return this.oldManagerCustomerIdFieldSpecified; }
      set { this.oldManagerCustomerIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class ManagedCustomerLink {
    private long managerCustomerIdField;

    private bool managerCustomerIdFieldSpecified;

    private long clientCustomerIdField;

    private bool clientCustomerIdFieldSpecified;

    private LinkStatus linkStatusField;

    private bool linkStatusFieldSpecified;

    private string pendingDescriptiveNameField;

    public long managerCustomerId {
      get { return this.managerCustomerIdField; }
      set {
        this.managerCustomerIdField = value;
        this.managerCustomerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool managerCustomerIdSpecified {
      get { return this.managerCustomerIdFieldSpecified; }
      set { this.managerCustomerIdFieldSpecified = value; }
    }

    public long clientCustomerId {
      get { return this.clientCustomerIdField; }
      set {
        this.clientCustomerIdField = value;
        this.clientCustomerIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clientCustomerIdSpecified {
      get { return this.clientCustomerIdFieldSpecified; }
      set { this.clientCustomerIdFieldSpecified = value; }
    }

    public LinkStatus linkStatus {
      get { return this.linkStatusField; }
      set {
        this.linkStatusField = value;
        this.linkStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool linkStatusSpecified {
      get { return this.linkStatusFieldSpecified; }
      set { this.linkStatusFieldSpecified = value; }
    }

    public string pendingDescriptiveName {
      get { return this.pendingDescriptiveNameField; }
      set { this.pendingDescriptiveNameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public enum LinkStatus {
    ACTIVE,
    INACTIVE,
    PENDING,
    REFUSED,
    CANCELLED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class LinkOperation : Operation {
    private ManagedCustomerLink operandField;

    public ManagedCustomerLink operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class PendingInvitation {
    private ManagedCustomer managerField;

    private ManagedCustomer clientField;

    private string creationDateField;

    private string expirationDateField;

    public ManagedCustomer manager {
      get { return this.managerField; }
      set { this.managerField = value; }
    }

    public ManagedCustomer client {
      get { return this.clientField; }
      set { this.clientField = value; }
    }

    public string creationDate {
      get { return this.creationDateField; }
      set { this.creationDateField = value; }
    }

    public string expirationDate {
      get { return this.expirationDateField; }
      set { this.expirationDateField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class PendingInvitationSelector {
    private long[] managerCustomerIdsField;

    private long[] clientCustomerIdsField;

    [System.Xml.Serialization.XmlElementAttribute("managerCustomerIds")]
    public long[] managerCustomerIds {
      get { return this.managerCustomerIdsField; }
      set { this.managerCustomerIdsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("clientCustomerIds")]
    public long[] clientCustomerIds {
      get { return this.clientCustomerIdsField; }
      set { this.clientCustomerIdsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class ManagedCustomerPage : Page {
    private ManagedCustomer[] entriesField;

    private ManagedCustomerLink[] linksField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public ManagedCustomer[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("links")]
    public ManagedCustomerLink[] links {
      get { return this.linksField; }
      set { this.linksField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public partial class ManagedCustomerServiceError : ApiError {
    private ManagedCustomerServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    private long[] customerIdsField;

    public ManagedCustomerServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("customerIds")]
    public long[] customerIds {
      get { return this.customerIdsField; }
      set { this.customerIdsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ManagedCustomerServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/mcm/v201409")]
  public enum ManagedCustomerServiceErrorReason {
    UNKNOWN,
    NOT_AUTHORIZED,
    INVALID_SELECTOR,
    INVALID_TIMEZONE,
    INVALID_CURRENCY,
    INVALID_DESCRIPTIVE_NAME,
    ADD_CUSTOMER_FAILURE,
    SAVE_CUSTOMERS_FAILURE,
    ALREADY_MANAGED_BY_THIS_MANAGER,
    ALREADY_INVITED_BY_THIS_MANAGER,
    NO_PENDING_INVITATION,
    TEST_ACCOUNT_LINK_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "MediaServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class MediaService : AdWordsSoapClient, IMediaService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public MediaService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/MediaService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual MediaPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((MediaPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual MediaPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((MediaPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Media[] upload([System.Xml.Serialization.XmlElementAttribute("media")]
Media[] media) {
      object[] results = this.Invoke("upload", new object[] { media });
      return ((Media[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MediaPage {
    private Media[] entriesField;

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Media[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class VideoError : ApiError {
    private VideoErrorReason reasonField;

    private bool reasonFieldSpecified;

    public VideoErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "VideoError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum VideoErrorReason {
    INVALID_VIDEO,
    STORAGE_ERROR,
    BAD_REQUEST,
    ERROR_GENERATING_STREAMING_URL,
    UNEXPECTED_SIZE,
    SERVER_ERROR,
    FILE_TOO_LARGE,
    VIDEO_PROCESSING_ERROR,
    INVALID_INPUT,
    PROBLEM_READING_FILE,
    INVALID_ISCI,
    INVALID_AD_ID
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AudioError : ApiError {
    private AudioErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AudioErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AudioError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AudioErrorReason {
    INVALID_AUDIO,
    PROBLEM_READING_AUDIO_FILE,
    ERROR_STORING_AUDIO,
    FILE_TOO_LARGE,
    UNSUPPORTED_AUDIO,
    ERROR_GENERATING_STREAMING_URL
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "MutateJobServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class MutateJobService : AdWordsSoapClient, IMutateJobService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public MutateJobService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/MutateJobService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Job[] get(JobSelector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((Job[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual JobResult getResult(JobSelector selector) {
      object[] results = this.Invoke("getResult", new object[] { selector });
      return ((JobResult) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual SimpleMutateJob mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
Operation[] operations, BulkMutateJobPolicy policy) {
      object[] results = this.Invoke("mutate", new object[] { operations, policy });
      return ((SimpleMutateJob) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BulkMutateJobPolicy {
    private long[] prerequisiteJobIdsField;


    [System.Xml.Serialization.XmlElementAttribute("prerequisiteJobIds")]
    public long[] prerequisiteJobIds {
      get { return this.prerequisiteJobIdsField; }
      set { this.prerequisiteJobIdsField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ProductPartition : Criterion {
    private ProductPartitionType partitionTypeField;

    private bool partitionTypeFieldSpecified;

    private long parentCriterionIdField;

    private bool parentCriterionIdFieldSpecified;

    private ProductDimension caseValueField;

    public ProductPartitionType partitionType {
      get { return this.partitionTypeField; }
      set {
        this.partitionTypeField = value;
        this.partitionTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool partitionTypeSpecified {
      get { return this.partitionTypeFieldSpecified; }
      set { this.partitionTypeFieldSpecified = value; }
    }

    public long parentCriterionId {
      get { return this.parentCriterionIdField; }
      set {
        this.parentCriterionIdField = value;
        this.parentCriterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool parentCriterionIdSpecified {
      get { return this.parentCriterionIdFieldSpecified; }
      set { this.parentCriterionIdFieldSpecified = value; }
    }

    public ProductDimension caseValue {
      get { return this.caseValueField; }
      set { this.caseValueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ProductPartitionType {
    UNKNOWN,
    SUBDIVISION,
    UNIT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AppPaymentModel : Criterion {
    private AppPaymentModelAppPaymentModelType appPaymentModelTypeField;

    private bool appPaymentModelTypeFieldSpecified;

    public AppPaymentModelAppPaymentModelType appPaymentModelType {
      get { return this.appPaymentModelTypeField; }
      set {
        this.appPaymentModelTypeField = value;
        this.appPaymentModelTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool appPaymentModelTypeSpecified {
      get { return this.appPaymentModelTypeFieldSpecified; }
      set { this.appPaymentModelTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AppPaymentModel.AppPaymentModelType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AppPaymentModelAppPaymentModelType {
    APP_PAYMENT_MODEL_PAID,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignTargetOperation : Operation {
    private TargetList operandField;

    public TargetList operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdScheduleTargetList))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class TargetList {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string targetListTypeField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("TargetList.Type")]
    public string TargetListType {
      get { return this.targetListTypeField; }
      set { this.targetListTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdScheduleTargetList : TargetList {
    private AdScheduleTarget[] targetsField;

    [System.Xml.Serialization.XmlElementAttribute("targets")]
    public AdScheduleTarget[] targets {
      get { return this.targetsField; }
      set { this.targetsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdScheduleTarget : Target {
    private DayOfWeek dayOfWeekField;

    private bool dayOfWeekFieldSpecified;

    private int startHourField;

    private bool startHourFieldSpecified;

    private MinuteOfHour startMinuteField;

    private bool startMinuteFieldSpecified;

    private int endHourField;

    private bool endHourFieldSpecified;

    private MinuteOfHour endMinuteField;

    private bool endMinuteFieldSpecified;

    private double bidMultiplierField;

    private bool bidMultiplierFieldSpecified;

    public DayOfWeek dayOfWeek {
      get { return this.dayOfWeekField; }
      set {
        this.dayOfWeekField = value;
        this.dayOfWeekSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool dayOfWeekSpecified {
      get { return this.dayOfWeekFieldSpecified; }
      set { this.dayOfWeekFieldSpecified = value; }
    }

    public int startHour {
      get { return this.startHourField; }
      set {
        this.startHourField = value;
        this.startHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startHourSpecified {
      get { return this.startHourFieldSpecified; }
      set { this.startHourFieldSpecified = value; }
    }

    public MinuteOfHour startMinute {
      get { return this.startMinuteField; }
      set {
        this.startMinuteField = value;
        this.startMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool startMinuteSpecified {
      get { return this.startMinuteFieldSpecified; }
      set { this.startMinuteFieldSpecified = value; }
    }

    public int endHour {
      get { return this.endHourField; }
      set {
        this.endHourField = value;
        this.endHourSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endHourSpecified {
      get { return this.endHourFieldSpecified; }
      set { this.endHourFieldSpecified = value; }
    }

    public MinuteOfHour endMinute {
      get { return this.endMinuteField; }
      set {
        this.endMinuteField = value;
        this.endMinuteSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool endMinuteSpecified {
      get { return this.endMinuteFieldSpecified; }
      set { this.endMinuteFieldSpecified = value; }
    }

    public double bidMultiplier {
      get { return this.bidMultiplierField; }
      set {
        this.bidMultiplierField = value;
        this.bidMultiplierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidMultiplierSpecified {
      get { return this.bidMultiplierFieldSpecified; }
      set { this.bidMultiplierFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdScheduleTarget))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class Target {
    private string targetTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Target.Type")]
    public string TargetType {
      get { return this.targetTypeField; }
      set { this.targetTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TargetingSetting : Setting {
    private TargetingSettingDetail[] detailsField;

    [System.Xml.Serialization.XmlElementAttribute("details")]
    public TargetingSettingDetail[] details {
      get { return this.detailsField; }
      set { this.detailsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class TargetingSettingDetail {
    private CriterionTypeGroup criterionTypeGroupField;

    private bool criterionTypeGroupFieldSpecified;

    private bool targetAllField;

    private bool targetAllFieldSpecified;

    public CriterionTypeGroup criterionTypeGroup {
      get { return this.criterionTypeGroupField; }
      set {
        this.criterionTypeGroupField = value;
        this.criterionTypeGroupSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionTypeGroupSpecified {
      get { return this.criterionTypeGroupFieldSpecified; }
      set { this.criterionTypeGroupFieldSpecified = value; }
    }

    public bool targetAll {
      get { return this.targetAllField; }
      set {
        this.targetAllField = value;
        this.targetAllSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool targetAllSpecified {
      get { return this.targetAllFieldSpecified; }
      set { this.targetAllFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CriterionTypeGroup {
    KEYWORD,
    USER_INTEREST_AND_LIST,
    VERTICAL,
    GENDER,
    AGE_RANGE,
    PLACEMENT,
    NONE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ExplorerAutoOptimizerSetting : Setting {
    private bool optInField;

    private bool optInFieldSpecified;

    public bool optIn {
      get { return this.optInField; }
      set {
        this.optInField = value;
        this.optInSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool optInSpecified {
      get { return this.optInFieldSpecified; }
      set { this.optInFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BudgetOperation : Operation {
    private Budget operandField;

    public Budget operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupOperation : Operation {
    private AdGroup operandField;

    public AdGroup operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroup {
    private long idField;

    private bool idFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string campaignNameField;

    private string nameField;

    private AdGroupStatus statusField;

    private bool statusFieldSpecified;

    private Setting[] settingsField;

    private AdGroupExperimentData experimentDataField;

    private Label[] labelsField;

    private String_StringMapEntry[] forwardCompatibilityMapField;

    private BiddingStrategyConfiguration biddingStrategyConfigurationField;

    private CriterionTypeGroup contentBidCriterionTypeGroupField;

    private bool contentBidCriterionTypeGroupFieldSpecified;

    private string trackingUrlTemplateField;

    private CustomParameters urlCustomParametersField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public string campaignName {
      get { return this.campaignNameField; }
      set { this.campaignNameField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public AdGroupStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("settings")]
    public Setting[] settings {
      get { return this.settingsField; }
      set { this.settingsField = value; }
    }

    public AdGroupExperimentData experimentData {
      get { return this.experimentDataField; }
      set { this.experimentDataField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("labels")]
    public Label[] labels {
      get { return this.labelsField; }
      set { this.labelsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("forwardCompatibilityMap")]
    public String_StringMapEntry[] forwardCompatibilityMap {
      get { return this.forwardCompatibilityMapField; }
      set { this.forwardCompatibilityMapField = value; }
    }

    public BiddingStrategyConfiguration biddingStrategyConfiguration {
      get { return this.biddingStrategyConfigurationField; }
      set { this.biddingStrategyConfigurationField = value; }
    }

    public CriterionTypeGroup contentBidCriterionTypeGroup {
      get { return this.contentBidCriterionTypeGroupField; }
      set {
        this.contentBidCriterionTypeGroupField = value;
        this.contentBidCriterionTypeGroupSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool contentBidCriterionTypeGroupSpecified {
      get { return this.contentBidCriterionTypeGroupFieldSpecified; }
      set { this.contentBidCriterionTypeGroupFieldSpecified = value; }
    }

    public string trackingUrlTemplate {
      get { return this.trackingUrlTemplateField; }
      set { this.trackingUrlTemplateField = value; }
    }

    public CustomParameters urlCustomParameters {
      get { return this.urlCustomParametersField; }
      set { this.urlCustomParametersField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroup.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupStatus {
    UNKNOWN,
    ENABLED,
    PAUSED,
    REMOVED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupExperimentData {
    private long experimentIdField;

    private bool experimentIdFieldSpecified;

    private ExperimentDeltaStatus experimentDeltaStatusField;

    private bool experimentDeltaStatusFieldSpecified;

    private ExperimentDataStatus experimentDataStatusField;

    private bool experimentDataStatusFieldSpecified;

    private AdGroupExperimentBidMultipliers experimentBidMultipliersField;

    public long experimentId {
      get { return this.experimentIdField; }
      set {
        this.experimentIdField = value;
        this.experimentIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentIdSpecified {
      get { return this.experimentIdFieldSpecified; }
      set { this.experimentIdFieldSpecified = value; }
    }

    public ExperimentDeltaStatus experimentDeltaStatus {
      get { return this.experimentDeltaStatusField; }
      set {
        this.experimentDeltaStatusField = value;
        this.experimentDeltaStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDeltaStatusSpecified {
      get { return this.experimentDeltaStatusFieldSpecified; }
      set { this.experimentDeltaStatusFieldSpecified = value; }
    }

    public ExperimentDataStatus experimentDataStatus {
      get { return this.experimentDataStatusField; }
      set {
        this.experimentDataStatusField = value;
        this.experimentDataStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDataStatusSpecified {
      get { return this.experimentDataStatusFieldSpecified; }
      set { this.experimentDataStatusFieldSpecified = value; }
    }

    public AdGroupExperimentBidMultipliers experimentBidMultipliers {
      get { return this.experimentBidMultipliersField; }
      set { this.experimentBidMultipliersField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPMAdGroupExperimentBidMultipliers))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupExperimentBidMultipliers))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class AdGroupExperimentBidMultipliers {
    private string adGroupExperimentBidMultipliersTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupExperimentBidMultipliers.Type")]
    public string AdGroupExperimentBidMultipliersType {
      get { return this.adGroupExperimentBidMultipliersTypeField; }
      set { this.adGroupExperimentBidMultipliersTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ManualCPMAdGroupExperimentBidMultipliers : AdGroupExperimentBidMultipliers {
    private BidMultiplier maxCpmMultiplierField;

    public BidMultiplier maxCpmMultiplier {
      get { return this.maxCpmMultiplierField; }
      set { this.maxCpmMultiplierField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BidMultiplier {
    private double multiplierField;

    private bool multiplierFieldSpecified;

    private Bid multipliedBidField;

    public double multiplier {
      get { return this.multiplierField; }
      set {
        this.multiplierField = value;
        this.multiplierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool multiplierSpecified {
      get { return this.multiplierFieldSpecified; }
      set { this.multiplierFieldSpecified = value; }
    }

    public Bid multipliedBid {
      get { return this.multipliedBidField; }
      set { this.multipliedBidField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Bid {
    private Money amountField;

    public Money amount {
      get { return this.amountField; }
      set { this.amountField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ManualCPCAdGroupExperimentBidMultipliers : AdGroupExperimentBidMultipliers {
    private BidMultiplier maxCpcMultiplierField;

    private BidMultiplier maxContentCpcMultiplierField;

    public BidMultiplier maxCpcMultiplier {
      get { return this.maxCpcMultiplierField; }
      set { this.maxCpcMultiplierField = value; }
    }

    public BidMultiplier maxContentCpcMultiplier {
      get { return this.maxContentCpcMultiplierField; }
      set { this.maxContentCpcMultiplierField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupLabelOperation : Operation {
    private AdGroupLabel operandField;

    public AdGroupLabel operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupLabel {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private long labelIdField;

    private bool labelIdFieldSpecified;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public long labelId {
      get { return this.labelIdField; }
      set {
        this.labelIdField = value;
        this.labelIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool labelIdSpecified {
      get { return this.labelIdFieldSpecified; }
      set { this.labelIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionOperation : Operation {
    private AdGroupCriterion operandField;

    private ExemptionRequest[] exemptionRequestsField;

    public AdGroupCriterion operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("exemptionRequests")]
    public ExemptionRequest[] exemptionRequests {
      get { return this.exemptionRequestsField; }
      set { this.exemptionRequestsField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NegativeAdGroupCriterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiddableAdGroupCriterion))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterion {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private CriterionUse criterionUseField;

    private bool criterionUseFieldSpecified;

    private Criterion criterionField;

    private Label[] labelsField;

    private String_StringMapEntry[] forwardCompatibilityMapField;

    private string adGroupCriterionTypeField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public CriterionUse criterionUse {
      get { return this.criterionUseField; }
      set {
        this.criterionUseField = value;
        this.criterionUseSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionUseSpecified {
      get { return this.criterionUseFieldSpecified; }
      set { this.criterionUseFieldSpecified = value; }
    }

    public Criterion criterion {
      get { return this.criterionField; }
      set { this.criterionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("labels")]
    public Label[] labels {
      get { return this.labelsField; }
      set { this.labelsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("forwardCompatibilityMap")]
    public String_StringMapEntry[] forwardCompatibilityMap {
      get { return this.forwardCompatibilityMapField; }
      set { this.forwardCompatibilityMapField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterion.Type")]
    public string AdGroupCriterionType {
      get { return this.adGroupCriterionTypeField; }
      set { this.adGroupCriterionTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CriterionUse {
    BIDDABLE,
    NEGATIVE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class NegativeAdGroupCriterion : AdGroupCriterion {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddableAdGroupCriterion : AdGroupCriterion {
    private UserStatus userStatusField;

    private bool userStatusFieldSpecified;

    private SystemServingStatus systemServingStatusField;

    private bool systemServingStatusFieldSpecified;

    private ApprovalStatus approvalStatusField;

    private bool approvalStatusFieldSpecified;

    private string[] disapprovalReasonsField;

    private string destinationUrlField;

    private BiddableAdGroupCriterionExperimentData experimentDataField;

    private Bid firstPageCpcField;

    private Bid topOfPageCpcField;

    private QualityInfo qualityInfoField;

    private BiddingStrategyConfiguration biddingStrategyConfigurationField;

    private double bidModifierField;

    private bool bidModifierFieldSpecified;

    private UrlList finalUrlsField;

    private UrlList finalMobileUrlsField;

    private AppUrl[] finalAppUrlsField;

    private string trackingUrlTemplateField;

    private CustomParameters urlCustomParametersField;

    public UserStatus userStatus {
      get { return this.userStatusField; }
      set {
        this.userStatusField = value;
        this.userStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool userStatusSpecified {
      get { return this.userStatusFieldSpecified; }
      set { this.userStatusFieldSpecified = value; }
    }

    public SystemServingStatus systemServingStatus {
      get { return this.systemServingStatusField; }
      set {
        this.systemServingStatusField = value;
        this.systemServingStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool systemServingStatusSpecified {
      get { return this.systemServingStatusFieldSpecified; }
      set { this.systemServingStatusFieldSpecified = value; }
    }

    public ApprovalStatus approvalStatus {
      get { return this.approvalStatusField; }
      set {
        this.approvalStatusField = value;
        this.approvalStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool approvalStatusSpecified {
      get { return this.approvalStatusFieldSpecified; }
      set { this.approvalStatusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("disapprovalReasons")]
    public string[] disapprovalReasons {
      get { return this.disapprovalReasonsField; }
      set { this.disapprovalReasonsField = value; }
    }

    public string destinationUrl {
      get { return this.destinationUrlField; }
      set { this.destinationUrlField = value; }
    }

    public BiddableAdGroupCriterionExperimentData experimentData {
      get { return this.experimentDataField; }
      set { this.experimentDataField = value; }
    }

    public Bid firstPageCpc {
      get { return this.firstPageCpcField; }
      set { this.firstPageCpcField = value; }
    }

    public Bid topOfPageCpc {
      get { return this.topOfPageCpcField; }
      set { this.topOfPageCpcField = value; }
    }

    public QualityInfo qualityInfo {
      get { return this.qualityInfoField; }
      set { this.qualityInfoField = value; }
    }

    public BiddingStrategyConfiguration biddingStrategyConfiguration {
      get { return this.biddingStrategyConfigurationField; }
      set { this.biddingStrategyConfigurationField = value; }
    }

    public double bidModifier {
      get { return this.bidModifierField; }
      set {
        this.bidModifierField = value;
        this.bidModifierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidModifierSpecified {
      get { return this.bidModifierFieldSpecified; }
      set { this.bidModifierFieldSpecified = value; }
    }

    public UrlList finalUrls {
      get { return this.finalUrlsField; }
      set { this.finalUrlsField = value; }
    }

    public UrlList finalMobileUrls {
      get { return this.finalMobileUrlsField; }
      set { this.finalMobileUrlsField = value; }
    }

    [System.Xml.Serialization.XmlArrayItemAttribute("appUrls", IsNullable = false)]
    public AppUrl[] finalAppUrls {
      get { return this.finalAppUrlsField; }
      set { this.finalAppUrlsField = value; }
    }

    public string trackingUrlTemplate {
      get { return this.trackingUrlTemplateField; }
      set { this.trackingUrlTemplateField = value; }
    }

    public CustomParameters urlCustomParameters {
      get { return this.urlCustomParametersField; }
      set { this.urlCustomParametersField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum UserStatus {
    ENABLED,
    REMOVED,
    PAUSED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SystemServingStatus {
    ELIGIBLE,
    RARELY_SERVED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ApprovalStatus {
    APPROVED,
    PENDING_REVIEW,
    UNDER_REVIEW,
    DISAPPROVED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddableAdGroupCriterionExperimentData {
    private long experimentIdField;

    private bool experimentIdFieldSpecified;

    private ExperimentDeltaStatus experimentDeltaStatusField;

    private bool experimentDeltaStatusFieldSpecified;

    private ExperimentDataStatus experimentDataStatusField;

    private bool experimentDataStatusFieldSpecified;

    private AdGroupCriterionExperimentBidMultiplier experimentBidMultiplierField;

    public long experimentId {
      get { return this.experimentIdField; }
      set {
        this.experimentIdField = value;
        this.experimentIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentIdSpecified {
      get { return this.experimentIdFieldSpecified; }
      set { this.experimentIdFieldSpecified = value; }
    }

    public ExperimentDeltaStatus experimentDeltaStatus {
      get { return this.experimentDeltaStatusField; }
      set {
        this.experimentDeltaStatusField = value;
        this.experimentDeltaStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDeltaStatusSpecified {
      get { return this.experimentDeltaStatusFieldSpecified; }
      set { this.experimentDeltaStatusFieldSpecified = value; }
    }

    public ExperimentDataStatus experimentDataStatus {
      get { return this.experimentDataStatusField; }
      set {
        this.experimentDataStatusField = value;
        this.experimentDataStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool experimentDataStatusSpecified {
      get { return this.experimentDataStatusFieldSpecified; }
      set { this.experimentDataStatusFieldSpecified = value; }
    }

    public AdGroupCriterionExperimentBidMultiplier experimentBidMultiplier {
      get { return this.experimentBidMultiplierField; }
      set { this.experimentBidMultiplierField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ManualCPCAdGroupCriterionExperimentBidMultiplier))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class AdGroupCriterionExperimentBidMultiplier {
    private string adGroupCriterionExperimentBidMultiplierTypeField;

    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionExperimentBidMultiplier.Type")]
    public string AdGroupCriterionExperimentBidMultiplierType {
      get { return this.adGroupCriterionExperimentBidMultiplierTypeField; }
      set { this.adGroupCriterionExperimentBidMultiplierTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ManualCPCAdGroupCriterionExperimentBidMultiplier : AdGroupCriterionExperimentBidMultiplier {
    private BidMultiplier maxCpcMultiplierField;

    private MultiplierSource multiplierSourceField;

    private bool multiplierSourceFieldSpecified;

    public BidMultiplier maxCpcMultiplier {
      get { return this.maxCpcMultiplierField; }
      set { this.maxCpcMultiplierField = value; }
    }

    public MultiplierSource multiplierSource {
      get { return this.multiplierSourceField; }
      set {
        this.multiplierSourceField = value;
        this.multiplierSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool multiplierSourceSpecified {
      get { return this.multiplierSourceFieldSpecified; }
      set { this.multiplierSourceFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MultiplierSource {
    ADGROUP,
    CRITERION,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class QualityInfo {
    private bool isKeywordAdRelevanceAcceptableField;

    private bool isKeywordAdRelevanceAcceptableFieldSpecified;

    private bool isLandingPageQualityAcceptableField;

    private bool isLandingPageQualityAcceptableFieldSpecified;

    private bool isLandingPageLatencyAcceptableField;

    private bool isLandingPageLatencyAcceptableFieldSpecified;

    private int qualityScoreField;

    private bool qualityScoreFieldSpecified;

    public bool isKeywordAdRelevanceAcceptable {
      get { return this.isKeywordAdRelevanceAcceptableField; }
      set {
        this.isKeywordAdRelevanceAcceptableField = value;
        this.isKeywordAdRelevanceAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isKeywordAdRelevanceAcceptableSpecified {
      get { return this.isKeywordAdRelevanceAcceptableFieldSpecified; }
      set { this.isKeywordAdRelevanceAcceptableFieldSpecified = value; }
    }

    public bool isLandingPageQualityAcceptable {
      get { return this.isLandingPageQualityAcceptableField; }
      set {
        this.isLandingPageQualityAcceptableField = value;
        this.isLandingPageQualityAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isLandingPageQualityAcceptableSpecified {
      get { return this.isLandingPageQualityAcceptableFieldSpecified; }
      set { this.isLandingPageQualityAcceptableFieldSpecified = value; }
    }

    public bool isLandingPageLatencyAcceptable {
      get { return this.isLandingPageLatencyAcceptableField; }
      set {
        this.isLandingPageLatencyAcceptableField = value;
        this.isLandingPageLatencyAcceptableSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isLandingPageLatencyAcceptableSpecified {
      get { return this.isLandingPageLatencyAcceptableFieldSpecified; }
      set { this.isLandingPageLatencyAcceptableFieldSpecified = value; }
    }

    public int qualityScore {
      get { return this.qualityScoreField; }
      set {
        this.qualityScoreField = value;
        this.qualityScoreSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool qualityScoreSpecified {
      get { return this.qualityScoreFieldSpecified; }
      set { this.qualityScoreFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class UrlList {
    private string[] urlsField;


    [System.Xml.Serialization.XmlElementAttribute("urls")]
    public string[] urls {
      get { return this.urlsField; }
      set { this.urlsField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionLabelOperation : Operation {
    private AdGroupCriterionLabel operandField;

    public AdGroupCriterionLabel operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionLabel {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    private long labelIdField;

    private bool labelIdFieldSpecified;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public long criterionId {
      get { return this.criterionIdField; }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get { return this.criterionIdFieldSpecified; }
      set { this.criterionIdFieldSpecified = value; }
    }

    public long labelId {
      get { return this.labelIdField; }
      set {
        this.labelIdField = value;
        this.labelIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool labelIdSpecified {
      get { return this.labelIdFieldSpecified; }
      set { this.labelIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupBidModifierOperation : Operation {
    private AdGroupBidModifier operandField;

    public AdGroupBidModifier operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupBidModifier {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private Criterion criterionField;

    private double bidModifierField;

    private bool bidModifierFieldSpecified;

    private BidModifierSource bidModifierSourceField;

    private bool bidModifierSourceFieldSpecified;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public Criterion criterion {
      get { return this.criterionField; }
      set { this.criterionField = value; }
    }

    public double bidModifier {
      get { return this.bidModifierField; }
      set {
        this.bidModifierField = value;
        this.bidModifierSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidModifierSpecified {
      get { return this.bidModifierFieldSpecified; }
      set { this.bidModifierFieldSpecified = value; }
    }

    public BidModifierSource bidModifierSource {
      get { return this.bidModifierSourceField; }
      set {
        this.bidModifierSourceField = value;
        this.bidModifierSourceSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool bidModifierSourceSpecified {
      get { return this.bidModifierSourceFieldSpecified; }
      set { this.bidModifierSourceFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BidModifierSource {
    UNKNOWN,
    CAMPAIGN,
    AD_GROUP
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class PlaceHolder {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class Operand {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("Ad", typeof(Ad))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroup", typeof(AdGroup))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupAd", typeof(AdGroupAd))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupAdLabel", typeof(AdGroupAdLabel))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupBidModifier", typeof(AdGroupBidModifier))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterion", typeof(AdGroupCriterion))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionLabel", typeof(AdGroupCriterionLabel))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupLabel", typeof(AdGroupLabel))]
    [System.Xml.Serialization.XmlElementAttribute("Budget", typeof(Budget))]
    [System.Xml.Serialization.XmlElementAttribute("Campaign", typeof(Campaign))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignAdExtension", typeof(CampaignAdExtension))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterion", typeof(CampaignCriterion))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignLabel", typeof(CampaignLabel))]
    [System.Xml.Serialization.XmlElementAttribute("FeedItem", typeof(FeedItem))]
    [System.Xml.Serialization.XmlElementAttribute("Job", typeof(Job))]
    [System.Xml.Serialization.XmlElementAttribute("Label", typeof(Label))]
    [System.Xml.Serialization.XmlElementAttribute("Media", typeof(Media))]
    [System.Xml.Serialization.XmlElementAttribute("PlaceHolder", typeof(PlaceHolder))]
    [System.Xml.Serialization.XmlElementAttribute("Target", typeof(Target))]
    [System.Xml.Serialization.XmlElementAttribute("TargetList", typeof(TargetList))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleMutateJob))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class Job {
    private ApiErrorReason failureReasonField;

    private JobStats statsField;

    private BillingSummary billingSummaryField;

    private string jobTypeField;

    public ApiErrorReason failureReason {
      get { return this.failureReasonField; }
      set { this.failureReasonField = value; }
    }

    public JobStats stats {
      get { return this.statsField; }
      set { this.statsField = value; }
    }

    public BillingSummary billingSummary {
      get { return this.billingSummaryField; }
      set { this.billingSummaryField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("Job.Type")]
    public string JobType {
      get { return this.jobTypeField; }
      set { this.jobTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ApiErrorReason {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("AdErrorReason", typeof(AdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdExtensionErrorReason", typeof(AdExtensionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupAdErrorReason", typeof(AdGroupAdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupCriterionErrorReason", typeof(AdGroupCriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdGroupServiceErrorReason", typeof(AdGroupServiceErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AdxErrorReason", typeof(AdxErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AuthenticationErrorReason", typeof(AuthenticationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("AuthorizationErrorReason", typeof(AuthorizationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BetaErrorReason", typeof(BetaErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BiddingErrorReason", typeof(BiddingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BiddingErrorsReason", typeof(BiddingErrorsReason))]
    [System.Xml.Serialization.XmlElementAttribute("BiddingTransitionErrorReason", typeof(BiddingTransitionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BudgetErrorReason", typeof(BudgetErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("BulkMutateJobErrorReason", typeof(BulkMutateJobErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignAdExtensionErrorReason", typeof(CampaignAdExtensionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignCriterionErrorReason", typeof(CampaignCriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CampaignErrorReason", typeof(CampaignErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ClientTermsErrorReason", typeof(ClientTermsErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CollectionSizeErrorReason", typeof(CollectionSizeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("CriterionErrorReason", typeof(CriterionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DatabaseErrorReason", typeof(DatabaseErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DateErrorReason", typeof(DateErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DateRangeErrorReason", typeof(DateRangeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("DistinctErrorReason", typeof(DistinctErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityAccessDeniedReason", typeof(EntityAccessDeniedReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityCountLimitExceededReason", typeof(EntityCountLimitExceededReason))]
    [System.Xml.Serialization.XmlElementAttribute("EntityNotFoundReason", typeof(EntityNotFoundReason))]
    [System.Xml.Serialization.XmlElementAttribute("ExperimentErrorReason", typeof(ExperimentErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("FeedItemErrorReason", typeof(FeedItemErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ForwardCompatibilityErrorReason", typeof(ForwardCompatibilityErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("FunctionErrorReason", typeof(FunctionErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("FunctionParsingErrorReason", typeof(FunctionParsingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("IdErrorReason", typeof(IdErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ImageErrorReason", typeof(ImageErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("InternalApiErrorReason", typeof(InternalApiErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("JobErrorReason", typeof(JobErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("MediaErrorReason", typeof(MediaErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("MultiplierErrorReason", typeof(MultiplierErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NewEntityCreationErrorReason", typeof(NewEntityCreationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NotEmptyErrorReason", typeof(NotEmptyErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("NullErrorReason", typeof(NullErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("OperationAccessDeniedReason", typeof(OperationAccessDeniedReason))]
    [System.Xml.Serialization.XmlElementAttribute("OperatorErrorReason", typeof(OperatorErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("PagingErrorReason", typeof(PagingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("PolicyViolationErrorReason", typeof(PolicyViolationErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QueryErrorReason", typeof(QueryErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaCheckErrorReason", typeof(QuotaCheckErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("QuotaErrorReason", typeof(QuotaErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RangeErrorReason", typeof(RangeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RateExceededErrorReason", typeof(RateExceededErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("ReadOnlyErrorReason", typeof(ReadOnlyErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RegionCodeErrorReason", typeof(RegionCodeErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RejectedErrorReason", typeof(RejectedErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RequestErrorReason", typeof(RequestErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("RequiredErrorReason", typeof(RequiredErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("SelectorErrorReason", typeof(SelectorErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("SettingErrorReason", typeof(SettingErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("SizeLimitErrorReason", typeof(SizeLimitErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("StatsQueryErrorReason", typeof(StatsQueryErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("StringFormatErrorReason", typeof(StringFormatErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("StringLengthErrorReason", typeof(StringLengthErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("TargetErrorReason", typeof(TargetErrorReason))]
    [System.Xml.Serialization.XmlElementAttribute("UrlErrorReason", typeof(UrlErrorReason))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupCriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupCriterionErrorReason {
    AD_GROUP_CRITERION_LABEL_DOES_NOT_EXIST,
    AD_GROUP_CRITERION_LABEL_ALREADY_EXISTS,
    CANNOT_ADD_LABEL_TO_NEGATIVE_CRITERION,
    TOO_MANY_OPERTAIONS,
    CANT_UPDATE_NEGATIVE,
    CONCRETE_TYPE_REQUIRED,
    BID_INCOMPATIBLE_WITH_ADGROUP,
    CANNOT_TARGET_AND_EXCLUDE,
    ILLEGAL_URL,
    INVALID_KEYWORD_TEXT,
    INVALID_DESTINATION_URL,
    MISSING_DESTINATION_URL_TAG,
    KEYWORD_LEVEL_BID_NOT_SUPPORTED_FOR_MANUALCPM,
    INVALID_USER_STATUS,
    CANNOT_ADD_CRITERIA_TYPE,
    CANNOT_EXCLUDE_CRITERIA_TYPE,
    INVALID_PRODUCT_PARTITION_HIERARCHY,
    PRODUCT_PARTITION_UNIT_CANNOT_HAVE_CHILDREN,
    PRODUCT_PARTITION_SUBDIVISION_REQUIRES_OTHERS_CASE,
    PRODUCT_PARTITION_REQUIRES_SAME_DIMENSION_TYPE_AS_SIBLINGS,
    PRODUCT_PARTITION_ALREADY_EXISTS,
    PRODUCT_PARTITION_DOES_NOT_EXIST,
    PRODUCT_PARTITION_CANNOT_BE_REMOVED,
    INVALID_PRODUCT_PARTITION_TYPE,
    PRODUCT_PARTITION_ADD_MAY_ONLY_USE_TEMP_ID,
    OPERATIONS_FOR_TOO_MANY_SHOPPING_ADGROUPS,
    CANNOT_MODIFY_URL_FIELDS_WITH_DUPLICATE_ELEMENTS,
    CANNOT_SET_WITHOUT_FINAL_URLS,
    CANNOT_CLEAR_FINAL_URLS_IF_FINAL_MOBILE_URLS_EXIST,
    CANNOT_CLEAR_FINAL_URLS_IF_FINAL_APP_URLS_EXIST,
    CANNOT_CLEAR_FINAL_URLS_IF_TRACKING_URL_TEMPLATE_EXISTS,
    CANNOT_CLEAR_FINAL_URLS_IF_URL_CUSTOM_PARAMETERS_EXIST,
    CANNOT_SET_BOTH_DESTINATION_URL_AND_FINAL_URLS,
    CANNOT_SET_BOTH_DESTINATION_URL_AND_TRACKING_URL_TEMPLATE,
    FINAL_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE,
    FINAL_MOBILE_URLS_NOT_SUPPORTED_FOR_CRITERION_TYPE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupServiceError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupServiceErrorReason {
    DUPLICATE_ADGROUP_NAME,
    INVALID_ADGROUP_NAME,
    USE_SET_OPERATOR_AND_MARK_STATUS_TO_REMOVED,
    ADVERTISER_NOT_ON_CONTENT_NETWORK,
    BID_TOO_BIG,
    BID_TYPE_AND_BIDDING_STRATEGY_MISMATCH,
    MISSING_ADGROUP_NAME,
    ADGROUP_LABEL_DOES_NOT_EXIST,
    ADGROUP_LABEL_ALREADY_EXISTS,
    INVALID_CONTENT_BID_CRITERION_TYPE_GROUP
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BetaError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BetaErrorReason {
    BETA_FEATURE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingTransitionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BiddingTransitionErrorReason {
    BID_TO_POSITION_ENABLED,
    BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    BUDGET_OPTIMIZER_IS_ENABLED,
    CONVERSION_OPTIMIZER_IS_ENABLED,
    CONVERSION_TRACKING_NOT_ENABLED,
    CONVERSION_TRACKING_NOT_AVAILABLE_FOR_ACCOUNT_TYPE,
    USE_POSITION_PREFERENCE_IN_MANUALCPC_INSTEAD_TO_DISABLE_POSITION_PREFERENCE,
    INVALID_BID,
    CANNOT_SET_EXPLICIT_BID,
    EXPLICIT_BID_REQUIRED_FOR_TRANSITION,
    EXPLICIT_BID_TYPE_DOES_NOT_MATCH_CAMPAIGN_BIDDING_STRATEGY,
    MISSING_REQUIRED_BID,
    INVALID_STATUS,
    IS_CPM_CAMPAIGN,
    IS_PERCENT_CPA_CAMPAIGN,
    NOT_THE_PREVIOUS_BIDDING_STRATEGY,
    NOT_ENOUGH_CONVERSION_DATA,
    NOT_ENOUGH_CONVERSIONS,
    OPTED_IN_SEARCH,
    PROXY_BIDDING_ON,
    SITE_REMNANT_RESERVATION_ALLOWED,
    TRANSITION_TO_ITSELF,
    UNKNOWN_BIDDING_STRATEGY,
    UNSUPPORTED_TRANSITION,
    VCG_ENABLED,
    BIDDING_TRANSITION_FAILED,
    ACCELERATED_DELIVERY_NOT_SUPPORTED_FOR_BUDGET_OPTIMIZER,
    HAS_ACTIVE_EXPERIMENT,
    INCOMPATIBLE_WITH_CAMPAIGN_SETTING
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BulkMutateJobError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BulkMutateJobErrorReason {
    CAN_RETURN_RESULT_FOR_ONLY_COMPLETED_JOBS,
    CAN_RETURN_RESULT_FOR_ONLY_ONE_JOB,
    CANNOT_UPDATE_JOB_ONCE_ALL_REQUEST_PARTS_ARE_RECEIVED,
    INVALID_SCOPING_ENTITY_TYPE,
    MISSING_SCOPING_ENTITY_FOR_OPERATION_STREAM,
    MORE_THAN_ONE_SCOPING_ENTITY_TYPE,
    PAYLOAD_STORE_UNAVAILABLE,
    REQUEST_PART_IS_OUT_OF_ORDER,
    TOO_MANY_OPERATION_STREAMS_IN_REQUEST_PART,
    TOO_MANY_OPERATIONS_IN_JOB,
    TOO_MANY_OPERATIONS_IN_REQUEST_PART,
    TOO_MANY_RESULTS_TO_STORE,
    TOO_MANY_SCOPING_ENTITIES,
    UNKNOWN,
    LOST_RESULT,
    UNPROCESSED_RESULT,
    BATCH_FAILURE,
    SERVICE_PROVIDED_NO_RESULT
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "JobError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum JobErrorReason {
    DUPLICATE_JOB_KEY_FOR_CUSTOMER,
    JOB_TYPE_NOT_SUPPORTED,
    PREREQUISITE_JOB_FAILED,
    SELECTOR_CANNOT_USE_BOTH_JOB_IDS_AND_JOB_KEYS,
    TOO_LATE_TO_CANCEL_JOB,
    TOO_MANY_PREREQUISITE_JOBS,
    TOO_MANY_JOBS_IN_QUEUE,
    USER_CANCELED_JOB,
    WORKFLOW_FAILURE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "MultiplierError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum MultiplierErrorReason {
    MULTIPLIER_TOO_HIGH,
    MULTIPLIER_TOO_LOW,
    TOO_MANY_FRACTIONAL_DIGITS,
    MULTIPLIER_NOT_ALLOWED_FOR_BIDDING_STRATEGY,
    MULTIPLIER_NOT_ALLOWED_WHEN_BASE_BID_IS_MISSING,
    MULTIPLIER_NOT_ALLOWED_FOR_EXPERIMENT_DELTA_STATUS,
    NO_MULTIPLIER_SPECIFIED,
    MULTIPLIER_CAUSES_BID_TO_EXCEED_DAILY_BUDGET,
    MULTIPLIER_CAUSES_BID_TO_EXCEED_MONTHLY_BUDGET,
    MULTIPLIER_CAUSES_BID_TO_EXCEED_CUSTOM_BUDGET,
    MULTIPLIER_CAUSES_BID_TO_EXCEED_MAX_ALLOWED_BID,
    BID_LESS_THAN_MIN_ALLOWED_BID_WITH_MULTIPLIER,
    MULTIPLIER_AND_BIDDING_STRATEGY_TYPE_MISMATCH,
    MULTIPLIER_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PolicyViolationError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum PolicyViolationErrorReason {
    POLICY_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class JobStats {
    private int progressPercentField;

    private bool progressPercentFieldSpecified;

    private long pendingTimeMillisField;

    private bool pendingTimeMillisFieldSpecified;

    private long processingTimeMillisField;

    private bool processingTimeMillisFieldSpecified;

    private string jobStatsTypeField;

    public int progressPercent {
      get { return this.progressPercentField; }
      set {
        this.progressPercentField = value;
        this.progressPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool progressPercentSpecified {
      get { return this.progressPercentFieldSpecified; }
      set { this.progressPercentFieldSpecified = value; }
    }

    public long pendingTimeMillis {
      get { return this.pendingTimeMillisField; }
      set {
        this.pendingTimeMillisField = value;
        this.pendingTimeMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool pendingTimeMillisSpecified {
      get { return this.pendingTimeMillisFieldSpecified; }
      set { this.pendingTimeMillisFieldSpecified = value; }
    }

    public long processingTimeMillis {
      get { return this.processingTimeMillisField; }
      set {
        this.processingTimeMillisField = value;
        this.processingTimeMillisSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool processingTimeMillisSpecified {
      get { return this.processingTimeMillisFieldSpecified; }
      set { this.processingTimeMillisFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobStats.Type")]
    public string JobStatsType {
      get { return this.jobStatsTypeField; }
      set { this.jobStatsTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BillingSummary {
    private int numOperationsField;

    private bool numOperationsFieldSpecified;

    private long numUnitsField;

    private bool numUnitsFieldSpecified;

    public int numOperations {
      get { return this.numOperationsField; }
      set {
        this.numOperationsField = value;
        this.numOperationsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numOperationsSpecified {
      get { return this.numOperationsFieldSpecified; }
      set { this.numOperationsFieldSpecified = value; }
    }

    public long numUnits {
      get { return this.numUnitsField; }
      set {
        this.numUnitsField = value;
        this.numUnitsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool numUnitsSpecified {
      get { return this.numUnitsFieldSpecified; }
      set { this.numUnitsFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SimpleMutateJob : Job {
    private long idField;

    private bool idFieldSpecified;

    private BasicJobStatus statusField;

    private bool statusFieldSpecified;

    private JobEvent[] historyField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public BasicJobStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("history")]
    public JobEvent[] history {
      get { return this.historyField; }
      set { this.historyField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BasicJobStatus {
    COMPLETED,
    PROCESSING,
    FAILED,
    PENDING
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class JobEvent {
    private string dateTimeField;

    private string jobEventTypeField;

    public string dateTime {
      get { return this.dateTimeField; }
      set { this.dateTimeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobEvent.Type")]
    public string JobEventType {
      get { return this.jobEventTypeField; }
      set { this.jobEventTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SimpleMutateResult {
    private Operand[] resultsField;

    private ApiError[] errorsField;

    [System.Xml.Serialization.XmlElementAttribute("results")]
    public Operand[] results {
      get { return this.resultsField; }
      set { this.resultsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("errors")]
    public ApiError[] errors {
      get { return this.errorsField; }
      set { this.errorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CriterionPolicyError : PolicyViolationError {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class MultiplierError : ApiError {
    private MultiplierErrorReason reasonField;

    private bool reasonFieldSpecified;

    public MultiplierErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class JobError : ApiError {
    private JobErrorReason reasonField;

    private bool reasonFieldSpecified;

    public JobErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionLimitExceeded : EntityCountLimitExceeded {
    private AdGroupCriterionLimitExceededCriteriaLimitType limitTypeField;

    private bool limitTypeFieldSpecified;

    public AdGroupCriterionLimitExceededCriteriaLimitType limitType {
      get { return this.limitTypeField; }
      set {
        this.limitTypeField = value;
        this.limitTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool limitTypeSpecified {
      get { return this.limitTypeFieldSpecified; }
      set { this.limitTypeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupCriterionLimitExceeded.CriteriaLimitType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupCriterionLimitExceededCriteriaLimitType {
    ADGROUP_KEYWORD,
    ADGROUP_WEBSITE,
    ADGROUP_CRITERION,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BulkMutateJobError : ApiError {
    private BulkMutateJobErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BulkMutateJobErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupServiceError : ApiError {
    private AdGroupServiceErrorReason reasonField;

    private bool reasonFieldSpecified;

    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    public AdGroupServiceErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionError : ApiError {
    private AdGroupCriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupCriterionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class JobResult {
    private SimpleMutateResult itemField;

    [System.Xml.Serialization.XmlElementAttribute("SimpleMutateResult")]
    public SimpleMutateResult Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BulkMutateJobSelector))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public abstract partial class JobSelector {
    private bool includeHistoryField;

    private bool includeHistoryFieldSpecified;

    private bool includeStatsField;

    private bool includeStatsFieldSpecified;

    private string jobSelectorTypeField;

    public bool includeHistory {
      get { return this.includeHistoryField; }
      set {
        this.includeHistoryField = value;
        this.includeHistorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeHistorySpecified {
      get { return this.includeHistoryFieldSpecified; }
      set { this.includeHistoryFieldSpecified = value; }
    }

    public bool includeStats {
      get { return this.includeStatsField; }
      set {
        this.includeStatsField = value;
        this.includeStatsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeStatsSpecified {
      get { return this.includeStatsFieldSpecified; }
      set { this.includeStatsFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("JobSelector.Type")]
    public string JobSelectorType {
      get { return this.jobSelectorTypeField; }
      set { this.jobSelectorTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BulkMutateJobSelector : JobSelector {
    private long[] jobIdsField;

    private int resultPartIndexField;

    private bool resultPartIndexFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("jobIds")]
    public long[] jobIds {
      get { return this.jobIdsField; }
      set { this.jobIdsField = value; }
    }

    public int resultPartIndex {
      get { return this.resultPartIndexField; }
      set {
        this.resultPartIndexField = value;
        this.resultPartIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool resultPartIndexSpecified {
      get { return this.resultPartIndexFieldSpecified; }
      set { this.resultPartIndexFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "OfflineConversionFeedServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class OfflineConversionFeedService : AdWordsSoapClient, IOfflineConversionFeedService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public OfflineConversionFeedService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/OfflineConversionFeedService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual OfflineConversionFeedReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
OfflineConversionFeedOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((OfflineConversionFeedReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OfflineConversionFeedReturnValue : ListReturnValue {
    private OfflineConversionFeed[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public OfflineConversionFeed[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OfflineConversionFeed {
    private string googleClickIdField;

    private string conversionNameField;

    private string conversionTimeField;

    private double conversionValueField;

    private bool conversionValueFieldSpecified;

    private string conversionCurrencyCodeField;

    public string googleClickId {
      get { return this.googleClickIdField; }
      set { this.googleClickIdField = value; }
    }

    public string conversionName {
      get { return this.conversionNameField; }
      set { this.conversionNameField = value; }
    }

    public string conversionTime {
      get { return this.conversionTimeField; }
      set { this.conversionTimeField = value; }
    }

    public double conversionValue {
      get { return this.conversionValueField; }
      set {
        this.conversionValueField = value;
        this.conversionValueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool conversionValueSpecified {
      get { return this.conversionValueFieldSpecified; }
      set { this.conversionValueFieldSpecified = value; }
    }

    public string conversionCurrencyCode {
      get { return this.conversionCurrencyCodeField; }
      set { this.conversionCurrencyCodeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OfflineConversionError : ApiError {
    private OfflineConversionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public OfflineConversionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "OfflineConversionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum OfflineConversionErrorReason {
    UNPARSEABLE_GCLID,
    CONVERSION_PRECEDES_CLICK,
    FUTURE_CONVERSION_TIME,
    EXPIRED_CLICK,
    TOO_RECENT_CLICK,
    INVALID_CLICK,
    UNAUTHORIZED_USER,
    INVALID_CONVERSION_TYPE,
    CLICK_MISSING_CONVERSION_LABEL,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CurrencyCodeError : ApiError {
    private CurrencyCodeErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CurrencyCodeErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CurrencyCodeError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CurrencyCodeErrorReason {
    UNSUPPORTED_CURRENCY_CODE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class OfflineConversionFeedOperation : Operation {
    private OfflineConversionFeed operandField;

    public OfflineConversionFeed operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupFeedServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupFeedService : AdWordsSoapClient, IAdGroupFeedService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupFeedService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/AdGroupFeedService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupFeedPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((AdGroupFeedPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupFeedReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupFeedOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((AdGroupFeedReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupFeedPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((AdGroupFeedPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupFeedReturnValue : ListReturnValue {
    private AdGroupFeed[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupFeed[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupFeed {
    private long feedIdField;

    private bool feedIdFieldSpecified;

    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private Function matchingFunctionField;

    private int[] placeholderTypesField;

    private AdGroupFeedStatus statusField;

    private bool statusFieldSpecified;

    public long feedId {
      get { return this.feedIdField; }
      set {
        this.feedIdField = value;
        this.feedIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool feedIdSpecified {
      get { return this.feedIdFieldSpecified; }
      set { this.feedIdFieldSpecified = value; }
    }

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public Function matchingFunction {
      get { return this.matchingFunctionField; }
      set { this.matchingFunctionField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("placeholderTypes")]
    public int[] placeholderTypes {
      get { return this.placeholderTypesField; }
      set { this.placeholderTypesField = value; }
    }

    public AdGroupFeedStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupFeed.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupFeedStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupFeedOperation : Operation {
    private AdGroupFeed operandField;

    public AdGroupFeed operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupFeedPage : NullStatsPage {
    private AdGroupFeed[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupFeed[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupFeedError : ApiError {
    private AdGroupFeedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdGroupFeedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdGroupFeedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdGroupFeedErrorReason {
    FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE,
    INVALID_ID,
    CANNOT_ADD_ALREADY_EXISTING_ADGROUP_FEED,
    CANNOT_OPERATE_ON_REMOVED_ADGROUP_FEED,
    INVALID_PLACEHOLDER_TYPES,
    MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE,
    NO_EXISTING_LOCATION_CUSTOMER_FEED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ReportDefinitionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ReportDefinitionService : AdWordsSoapClient, IReportDefinitionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ReportDefinitionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/ReportDefinitionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ReportDefinitionField[] getReportFields(ReportDefinitionReportType reportType) {
      object[] results = this.Invoke("getReportFields", new object[] { reportType });
      return ((ReportDefinitionField[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class EnumValuePair {
    private string enumValueField;

    private string enumDisplayValueField;

    public string enumValue {
      get { return this.enumValueField; }
      set { this.enumValueField = value; }
    }

    public string enumDisplayValue {
      get { return this.enumDisplayValueField; }
      set { this.enumDisplayValueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ReportDefinitionField {
    private string fieldNameField;

    private string displayFieldNameField;

    private string xmlAttributeNameField;

    private string fieldTypeField;

    private string fieldBehaviorField;

    private string[] enumValuesField;

    private bool canSelectField;

    private bool canSelectFieldSpecified;

    private bool canFilterField;

    private bool canFilterFieldSpecified;

    private bool isEnumTypeField;

    private bool isEnumTypeFieldSpecified;

    private bool isBetaField;

    private bool isBetaFieldSpecified;

    private bool isZeroRowCompatibleField;

    private bool isZeroRowCompatibleFieldSpecified;

    private EnumValuePair[] enumValuePairsField;

    public string fieldName {
      get { return this.fieldNameField; }
      set { this.fieldNameField = value; }
    }

    public string displayFieldName {
      get { return this.displayFieldNameField; }
      set { this.displayFieldNameField = value; }
    }

    public string xmlAttributeName {
      get { return this.xmlAttributeNameField; }
      set { this.xmlAttributeNameField = value; }
    }

    public string fieldType {
      get { return this.fieldTypeField; }
      set { this.fieldTypeField = value; }
    }

    public string fieldBehavior {
      get { return this.fieldBehaviorField; }
      set { this.fieldBehaviorField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("enumValues")]
    public string[] enumValues {
      get { return this.enumValuesField; }
      set { this.enumValuesField = value; }
    }

    public bool canSelect {
      get { return this.canSelectField; }
      set {
        this.canSelectField = value;
        this.canSelectSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool canSelectSpecified {
      get { return this.canSelectFieldSpecified; }
      set { this.canSelectFieldSpecified = value; }
    }

    public bool canFilter {
      get { return this.canFilterField; }
      set {
        this.canFilterField = value;
        this.canFilterSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool canFilterSpecified {
      get { return this.canFilterFieldSpecified; }
      set { this.canFilterFieldSpecified = value; }
    }

    public bool isEnumType {
      get { return this.isEnumTypeField; }
      set {
        this.isEnumTypeField = value;
        this.isEnumTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isEnumTypeSpecified {
      get { return this.isEnumTypeFieldSpecified; }
      set { this.isEnumTypeFieldSpecified = value; }
    }

    public bool isBeta {
      get { return this.isBetaField; }
      set {
        this.isBetaField = value;
        this.isBetaSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isBetaSpecified {
      get { return this.isBetaFieldSpecified; }
      set { this.isBetaFieldSpecified = value; }
    }

    public bool isZeroRowCompatible {
      get { return this.isZeroRowCompatibleField; }
      set {
        this.isZeroRowCompatibleField = value;
        this.isZeroRowCompatibleSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isZeroRowCompatibleSpecified {
      get { return this.isZeroRowCompatibleFieldSpecified; }
      set { this.isZeroRowCompatibleFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("enumValuePairs")]
    public EnumValuePair[] enumValuePairs {
      get { return this.enumValuePairsField; }
      set { this.enumValuePairsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class ReportDefinitionError : ApiError {
    private ReportDefinitionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ReportDefinitionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReportDefinitionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ReportDefinitionErrorReason {
    INVALID_DATE_RANGE_FOR_REPORT,
    INVALID_FIELD_NAME_FOR_REPORT,
    UNABLE_TO_FIND_MAPPING_FOR_THIS_REPORT,
    INVALID_COLUMN_NAME_FOR_REPORT,
    INVALID_REPORT_DEFINITION_ID,
    REPORT_SELECTOR_CANNOT_BE_NULL,
    NO_ENUMS_FOR_THIS_COLUMN_NAME,
    INVALID_VIEW,
    SORTING_NOT_SUPPORTED,
    PAGING_NOT_SUPPORTED,
    CUSTOMER_SERVING_TYPE_REPORT_MISMATCH,
    CLIENT_SELECTOR_NO_CUSTOMER_IDENTIFIER,
    CLIENT_SELECTOR_INVALID_CUSTOMER_ID,
    REPORT_DEFINITION_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class NotWhitelistedError : ApiError {
    private NotWhitelistedErrorReason reasonField;

    private bool reasonFieldSpecified;

    public NotWhitelistedErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NotWhitelistedError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum NotWhitelistedErrorReason {
    CUSTOMER_NOT_WHITELISTED_FOR_API
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ReportDefinition.ReportType", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum ReportDefinitionReportType {
    KEYWORDS_PERFORMANCE_REPORT,
    AD_PERFORMANCE_REPORT,
    URL_PERFORMANCE_REPORT,
    ADGROUP_PERFORMANCE_REPORT,
    CAMPAIGN_PERFORMANCE_REPORT,
    ACCOUNT_PERFORMANCE_REPORT,
    GEO_PERFORMANCE_REPORT,
    SEARCH_QUERY_PERFORMANCE_REPORT,
    AUTOMATIC_PLACEMENTS_PERFORMANCE_REPORT,
    CAMPAIGN_NEGATIVE_KEYWORDS_PERFORMANCE_REPORT,
    CAMPAIGN_NEGATIVE_PLACEMENTS_PERFORMANCE_REPORT,
    AD_EXTENSIONS_PERFORMANCE_REPORT,
    DESTINATION_URL_REPORT,
    SHARED_SET_REPORT,
    CAMPAIGN_SHARED_SET_REPORT,
    SHARED_SET_CRITERIA_REPORT,
    CREATIVE_CONVERSION_REPORT,
    CALL_METRICS_CALL_DETAILS_REPORT,
    KEYWORDLESS_QUERY_REPORT,
    KEYWORDLESS_CATEGORY_REPORT,
    ACCOUNT_REACH_FREQUENCY_REPORT,
    CAMPAIGN_REACH_FREQUENCY_REPORT,
    ADGROUP_REACH_FREQUENCY_REPORT,
    CRITERIA_PERFORMANCE_REPORT,
    CLICK_PERFORMANCE_REPORT,
    BUDGET_PERFORMANCE_REPORT,
    BID_GOAL_PERFORMANCE_REPORT,
    DISPLAY_KEYWORD_PERFORMANCE_REPORT,
    PLACEHOLDER_FEED_ITEM_REPORT,
    PLACEMENT_PERFORMANCE_REPORT,
    CAMPAIGN_NEGATIVE_LOCATIONS_REPORT,
    GENDER_PERFORMANCE_REPORT,
    AGE_RANGE_PERFORMANCE_REPORT,
    CAMPAIGN_LOCATION_TARGET_REPORT,
    CAMPAIGN_AD_SCHEDULE_TARGET_REPORT,
    CAMPAIGN_PLATFORM_TARGET_REPORT,
    PAID_ORGANIC_QUERY_REPORT,
    AUDIENCE_PERFORMANCE_REPORT,
    DISPLAY_TOPICS_PERFORMANCE_REPORT,
    SHOPPING_PERFORMANCE_REPORT,
    PRODUCT_PARTITION_REPORT,
    PLACEHOLDER_REPORT,
    AD_PLACEHOLDER_FEED_ITEM_REPORT,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "TargetingIdeaServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataEntry))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class TargetingIdeaService : AdWordsSoapClient, ITargetingIdeaService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public TargetingIdeaService() {
      this.Url = "https://adwords.google.com/api/adwords/o/v201409/TargetingIdeaService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual TargetingIdeaPage get(TargetingIdeaSelector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((TargetingIdeaPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class WebpageDescriptor {
    private string urlField;

    private string titleField;

    public string url {
      get { return this.urlField; }
      set { this.urlField = value; }
    }

    public string title {
      get { return this.titleField; }
      set { this.titleField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class MonthlySearchVolume {
    private int yearField;

    private bool yearFieldSpecified;

    private int monthField;

    private bool monthFieldSpecified;

    private long countField;

    private bool countFieldSpecified;

    public int year {
      get { return this.yearField; }
      set {
        this.yearField = value;
        this.yearSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool yearSpecified {
      get { return this.yearFieldSpecified; }
      set { this.yearFieldSpecified = value; }
    }

    public int month {
      get { return this.monthField; }
      set {
        this.monthField = value;
        this.monthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool monthSpecified {
      get { return this.monthFieldSpecified; }
      set { this.monthFieldSpecified = value; }
    }

    public long count {
      get { return this.countField; }
      set {
        this.countField = value;
        this.countSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool countSpecified {
      get { return this.countFieldSpecified; }
      set { this.countFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class Range {
    private ComparableValue minField;

    private ComparableValue maxField;

    public ComparableValue min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public ComparableValue max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class InStreamAdInfo {
    private int maxAdDurationField;

    private bool maxAdDurationFieldSpecified;

    private int minAdDurationField;

    private bool minAdDurationFieldSpecified;

    private int medianAdDurationField;

    private bool medianAdDurationFieldSpecified;

    private double preRollPercentField;

    private bool preRollPercentFieldSpecified;

    private double midRollPercentField;

    private bool midRollPercentFieldSpecified;

    private double postRollPercentField;

    private bool postRollPercentFieldSpecified;

    public int maxAdDuration {
      get { return this.maxAdDurationField; }
      set {
        this.maxAdDurationField = value;
        this.maxAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maxAdDurationSpecified {
      get { return this.maxAdDurationFieldSpecified; }
      set { this.maxAdDurationFieldSpecified = value; }
    }

    public int minAdDuration {
      get { return this.minAdDurationField; }
      set {
        this.minAdDurationField = value;
        this.minAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool minAdDurationSpecified {
      get { return this.minAdDurationFieldSpecified; }
      set { this.minAdDurationFieldSpecified = value; }
    }

    public int medianAdDuration {
      get { return this.medianAdDurationField; }
      set {
        this.medianAdDurationField = value;
        this.medianAdDurationSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool medianAdDurationSpecified {
      get { return this.medianAdDurationFieldSpecified; }
      set { this.medianAdDurationFieldSpecified = value; }
    }

    public double preRollPercent {
      get { return this.preRollPercentField; }
      set {
        this.preRollPercentField = value;
        this.preRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool preRollPercentSpecified {
      get { return this.preRollPercentFieldSpecified; }
      set { this.preRollPercentFieldSpecified = value; }
    }

    public double midRollPercent {
      get { return this.midRollPercentField; }
      set {
        this.midRollPercentField = value;
        this.midRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool midRollPercentSpecified {
      get { return this.midRollPercentFieldSpecified; }
      set { this.midRollPercentFieldSpecified = value; }
    }

    public double postRollPercent {
      get { return this.postRollPercentField; }
      set {
        this.postRollPercentField = value;
        this.postRollPercentSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool postRollPercentSpecified {
      get { return this.postRollPercentFieldSpecified; }
      set { this.postRollPercentFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TextAdSpec {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class InStreamAdSpec {
    private InStreamAdSpecInStreamType[] inStreamTypesField;

    private long[] durationsField;

    [System.Xml.Serialization.XmlElementAttribute("inStreamTypes")]
    public InStreamAdSpecInStreamType[] inStreamTypes {
      get { return this.inStreamTypesField; }
      set { this.inStreamTypesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("durations")]
    public long[] durations {
      get { return this.durationsField; }
      set { this.durationsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "InStreamAdSpec.InStreamType", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum InStreamAdSpecInStreamType {
    UNKNOWN,
    IN_STREAM,
    IN_DISPLAY,
    IN_SLATE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DisplayAdSpec.AdSizeSpec", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class DisplayAdSpecAdSizeSpec {
    private long widthField;

    private bool widthFieldSpecified;

    private long heightField;

    private bool heightFieldSpecified;

    private DisplayAdSpecActivationOption[] activationOptionFilterField;

    public long width {
      get { return this.widthField; }
      set {
        this.widthField = value;
        this.widthSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool widthSpecified {
      get { return this.widthFieldSpecified; }
      set { this.widthFieldSpecified = value; }
    }

    public long height {
      get { return this.heightField; }
      set {
        this.heightField = value;
        this.heightSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool heightSpecified {
      get { return this.heightFieldSpecified; }
      set { this.heightFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("activationOptionFilter")]
    public DisplayAdSpecActivationOption[] activationOptionFilter {
      get { return this.activationOptionFilterField; }
      set { this.activationOptionFilterField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DisplayAdSpec.ActivationOption", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum DisplayAdSpecActivationOption {
    UNKNOWN,
    NONE,
    STANDARD_EXPANDABLE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class ImageDisplayType {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class HtmlDisplayType {
    private HtmlDisplayTypeHtmlOption htmlOptionField;

    private bool htmlOptionFieldSpecified;

    public HtmlDisplayTypeHtmlOption htmlOption {
      get { return this.htmlOptionField; }
      set {
        this.htmlOptionField = value;
        this.htmlOptionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool htmlOptionSpecified {
      get { return this.htmlOptionFieldSpecified; }
      set { this.htmlOptionFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "HtmlDisplayType.HtmlOption", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum HtmlDisplayTypeHtmlOption {
    UNKNOWN,
    THIRD_PARTY_SERVING
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class FlashDisplayType {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class DisplayType {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("FlashDisplayType", typeof(FlashDisplayType))]
    [System.Xml.Serialization.XmlElementAttribute("HtmlDisplayType", typeof(HtmlDisplayType))]
    [System.Xml.Serialization.XmlElementAttribute("ImageDisplayType", typeof(ImageDisplayType))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class DisplayAdSpec {
    private DisplayType[] displayTypesField;

    private DisplayAdSpecActivationOption[] activationOptionsField;

    private DisplayAdSpecAdSizeSpec[] adSizeSpecsField;

    [System.Xml.Serialization.XmlElementAttribute("displayTypes")]
    public DisplayType[] displayTypes {
      get { return this.displayTypesField; }
      set { this.displayTypesField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("activationOptions")]
    public DisplayAdSpecActivationOption[] activationOptions {
      get { return this.activationOptionsField; }
      set { this.activationOptionsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adSizeSpecs")]
    public DisplayAdSpecAdSizeSpec[] adSizeSpecs {
      get { return this.adSizeSpecsField; }
      set { this.adSizeSpecsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class AdSpec {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("DisplayAdSpec", typeof(DisplayAdSpec))]
    [System.Xml.Serialization.XmlElementAttribute("InStreamAdSpec", typeof(InStreamAdSpec))]
    [System.Xml.Serialization.XmlElementAttribute("TextAdSpec", typeof(TextAdSpec))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class AdFormatSpec {
    private SiteConstantsAdFormat formatField;

    private bool formatFieldSpecified;

    public SiteConstantsAdFormat format {
      get { return this.formatField; }
      set {
        this.formatField = value;
        this.formatSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool formatSpecified {
      get { return this.formatFieldSpecified; }
      set { this.formatFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.AdFormat", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum SiteConstantsAdFormat {
    UNKNOWN,
    TEXT,
    IMAGE,
    VIDEO,
    INSTREAM
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(WebpageDescriptorAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(StringAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlacementAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpportunityIdeaTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MonthlySearchVolumeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(MoneyAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongRangeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LongAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerSetAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IntegerAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(InStreamAdInfoAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdeaTypeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BooleanAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BidLandscapeAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdSpecListAttribute))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdFormatSpecListAttribute))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public abstract partial class Attribute {
    private string attributeTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Attribute.Type")]
    public string AttributeType {
      get { return this.attributeTypeField; }
      set { this.attributeTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class WebpageDescriptorAttribute : Attribute {
    private WebpageDescriptor valueField;

    public WebpageDescriptor value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class StringAttribute : Attribute {
    private string valueField;

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class PlacementTypeAttribute : Attribute {
    private SiteConstantsPlacementType valueField;

    private bool valueFieldSpecified;

    public SiteConstantsPlacementType value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SiteConstants.PlacementType", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum SiteConstantsPlacementType {
    UNKNOWN,
    SITE,
    VIDEO,
    FEED,
    GAME,
    MOBILE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class PlacementAttribute : Attribute {
    private Placement valueField;

    public Placement value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class OpportunityIdeaTypeAttribute : Attribute {
    private OpportunityIdeaType valueField;

    private bool valueFieldSpecified;

    public OpportunityIdeaType value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum OpportunityIdeaType {
    KEYWORD,
    BID,
    BUDGET
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class MonthlySearchVolumeAttribute : Attribute {
    private MonthlySearchVolume[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public MonthlySearchVolume[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class MoneyAttribute : Attribute {
    private Money valueField;

    public Money value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class LongRangeAttribute : Attribute {
    private Range valueField;

    public Range value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class LongAttribute : Attribute {
    private long valueField;

    private bool valueFieldSpecified;

    public long value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class KeywordAttribute : Attribute {
    private Keyword valueField;

    public Keyword value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class IntegerSetAttribute : Attribute {
    private int[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public int[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class IntegerAttribute : Attribute {
    private int valueField;

    private bool valueFieldSpecified;

    public int value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class InStreamAdInfoAttribute : Attribute {
    private InStreamAdInfo valueField;

    public InStreamAdInfo value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class IdeaTypeAttribute : Attribute {
    private IdeaType valueField;

    private bool valueFieldSpecified;

    public IdeaType value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum IdeaType {
    KEYWORD
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class DoubleAttribute : Attribute {
    private double valueField;

    private bool valueFieldSpecified;

    public double value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class CriterionAttribute : Attribute {
    private Criterion valueField;

    public Criterion value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class BooleanAttribute : Attribute {
    private bool valueField;

    private bool valueFieldSpecified;

    public bool value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class BidLandscapeAttribute : Attribute {
    private BidLandscape valueField;

    public BidLandscape value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class AdSpecListAttribute : Attribute {
    private AdSpec[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdSpec[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class AdFormatSpecListAttribute : Attribute {
    private AdFormatSpec[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdFormatSpec[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class Type_AttributeMapEntry {
    private AttributeType keyField;

    private bool keyFieldSpecified;

    private Attribute valueField;

    public AttributeType key {
      get { return this.keyField; }
      set {
        this.keyField = value;
        this.keySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool keySpecified {
      get { return this.keyFieldSpecified; }
      set { this.keyFieldSpecified = value; }
    }

    public Attribute value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum AttributeType {
    UNKNOWN,
    CATEGORY_PRODUCTS_AND_SERVICES,
    COMPETITION,
    CRITERION,
    EXTRACTED_FROM_WEBPAGE,
    IDEA_TYPE,
    KEYWORD_TEXT,
    SEARCH_VOLUME,
    AVERAGE_CPC,
    TARGETED_MONTHLY_SEARCHES
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TargetingIdea {
    private Type_AttributeMapEntry[] dataField;


    [System.Xml.Serialization.XmlElementAttribute("data")]
    public Type_AttributeMapEntry[] data {
      get { return this.dataField; }
      set { this.dataField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TargetingIdeaPage {
    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    private TargetingIdea[] entriesField;

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public TargetingIdea[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class LongComparisonOperation {
    private long minimumField;

    private bool minimumFieldSpecified;

    private long maximumField;

    private bool maximumFieldSpecified;

    public long minimum {
      get { return this.minimumField; }
      set {
        this.minimumField = value;
        this.minimumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool minimumSpecified {
      get { return this.minimumFieldSpecified; }
      set { this.minimumFieldSpecified = value; }
    }

    public long maximum {
      get { return this.maximumField; }
      set {
        this.maximumField = value;
        this.maximumSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool maximumSpecified {
      get { return this.maximumFieldSpecified; }
      set { this.maximumFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SeedAdGroupIdSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchVolumeSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedToUrlSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelatedToQuerySearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(NetworkSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LanguageSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IncludeAdultContentSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(IdeaTextFilterSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExcludedKeywordSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompetitionSearchParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CategoryProductsAndServicesSearchParameter))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public abstract partial class SearchParameter {
    private string searchParameterTypeField;

    [System.Xml.Serialization.XmlElementAttribute("SearchParameter.Type")]
    public string SearchParameterType {
      get { return this.searchParameterTypeField; }
      set { this.searchParameterTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class SeedAdGroupIdSearchParameter : SearchParameter {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class SearchVolumeSearchParameter : SearchParameter {
    private LongComparisonOperation operationField;

    public LongComparisonOperation operation {
      get { return this.operationField; }
      set { this.operationField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class RelatedToUrlSearchParameter : SearchParameter {
    private string[] urlsField;

    private bool includeSubUrlsField;

    private bool includeSubUrlsFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("urls")]
    public string[] urls {
      get { return this.urlsField; }
      set { this.urlsField = value; }
    }

    public bool includeSubUrls {
      get { return this.includeSubUrlsField; }
      set {
        this.includeSubUrlsField = value;
        this.includeSubUrlsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool includeSubUrlsSpecified {
      get { return this.includeSubUrlsFieldSpecified; }
      set { this.includeSubUrlsFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class RelatedToQuerySearchParameter : SearchParameter {
    private string[] queriesField;

    [System.Xml.Serialization.XmlElementAttribute("queries")]
    public string[] queries {
      get { return this.queriesField; }
      set { this.queriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class NetworkSearchParameter : SearchParameter {
    private NetworkSetting networkSettingField;

    public NetworkSetting networkSetting {
      get { return this.networkSettingField; }
      set { this.networkSettingField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class LocationSearchParameter : SearchParameter {
    private Location[] locationsField;

    [System.Xml.Serialization.XmlElementAttribute("locations")]
    public Location[] locations {
      get { return this.locationsField; }
      set { this.locationsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class LanguageSearchParameter : SearchParameter {
    private Language[] languagesField;

    [System.Xml.Serialization.XmlElementAttribute("languages")]
    public Language[] languages {
      get { return this.languagesField; }
      set { this.languagesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class IncludeAdultContentSearchParameter : SearchParameter {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class IdeaTextFilterSearchParameter : SearchParameter {
    private string[] includedField;

    private string[] excludedField;

    [System.Xml.Serialization.XmlElementAttribute("included")]
    public string[] included {
      get { return this.includedField; }
      set { this.includedField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("excluded")]
    public string[] excluded {
      get { return this.excludedField; }
      set { this.excludedField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class ExcludedKeywordSearchParameter : SearchParameter {
    private Keyword[] keywordsField;

    [System.Xml.Serialization.XmlElementAttribute("keywords")]
    public Keyword[] keywords {
      get { return this.keywordsField; }
      set { this.keywordsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class CompetitionSearchParameter : SearchParameter {
    private CompetitionSearchParameterLevel[] levelsField;

    [System.Xml.Serialization.XmlElementAttribute("levels")]
    public CompetitionSearchParameterLevel[] levels {
      get { return this.levelsField; }
      set { this.levelsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CompetitionSearchParameter.Level", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum CompetitionSearchParameterLevel {
    LOW,
    MEDIUM,
    HIGH
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class CategoryProductsAndServicesSearchParameter : SearchParameter {
    private int categoryIdField;

    private bool categoryIdFieldSpecified;

    public int categoryId {
      get { return this.categoryIdField; }
      set {
        this.categoryIdField = value;
        this.categoryIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categoryIdSpecified {
      get { return this.categoryIdFieldSpecified; }
      set { this.categoryIdFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TargetingIdeaSelector {
    private SearchParameter[] searchParametersField;

    private IdeaType ideaTypeField;

    private bool ideaTypeFieldSpecified;

    private RequestType requestTypeField;

    private bool requestTypeFieldSpecified;

    private AttributeType[] requestedAttributeTypesField;

    private Paging pagingField;

    private string localeCodeField;

    private string currencyCodeField;

    [System.Xml.Serialization.XmlElementAttribute("searchParameters")]
    public SearchParameter[] searchParameters {
      get { return this.searchParametersField; }
      set { this.searchParametersField = value; }
    }

    public IdeaType ideaType {
      get { return this.ideaTypeField; }
      set {
        this.ideaTypeField = value;
        this.ideaTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ideaTypeSpecified {
      get { return this.ideaTypeFieldSpecified; }
      set { this.ideaTypeFieldSpecified = value; }
    }

    public RequestType requestType {
      get { return this.requestTypeField; }
      set {
        this.requestTypeField = value;
        this.requestTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool requestTypeSpecified {
      get { return this.requestTypeFieldSpecified; }
      set { this.requestTypeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("requestedAttributeTypes")]
    public AttributeType[] requestedAttributeTypes {
      get { return this.requestedAttributeTypesField; }
      set { this.requestedAttributeTypesField = value; }
    }

    public Paging paging {
      get { return this.pagingField; }
      set { this.pagingField = value; }
    }

    public string localeCode {
      get { return this.localeCodeField; }
      set { this.localeCodeField = value; }
    }

    public string currencyCode {
      get { return this.currencyCodeField; }
      set { this.currencyCodeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum RequestType {
    IDEAS,
    STATS
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TrafficEstimatorError : ApiError {
    private TrafficEstimatorErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TrafficEstimatorErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TrafficEstimatorError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum TrafficEstimatorErrorReason {
    NO_CAMPAIGN_FOR_AD_GROUP_ESTIMATE_REQUEST,
    NO_AD_GROUP_FOR_KEYWORD_ESTIMATE_REQUEST,
    NO_MAX_CPC_FOR_KEYWORD_ESTIMATE_REQUEST,
    TOO_MANY_KEYWORD_ESTIMATE_REQUESTS,
    TOO_MANY_CAMPAIGN_ESTIMATE_REQUESTS,
    TOO_MANY_ADGROUP_ESTIMATE_REQUESTS,
    TOO_MANY_TARGETS,
    KEYWORD_TOO_LONG,
    KEYWORD_CONTAINS_BROAD_MATCH_MODIFIERS,
    INVALID_INPUT,
    SERVICE_UNAVAILABLE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TargetingIdeaError : ApiError {
    private TargetingIdeaErrorReason reasonField;

    private bool reasonFieldSpecified;

    public TargetingIdeaErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "TargetingIdeaError.Reason", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public enum TargetingIdeaErrorReason {
    DUPLICATE_SEARCH_FILTER_TYPES_PRESENT,
    INSUFFICIENT_SEARCH_PARAMETERS,
    INVALID_ATTRIBUTE_TYPE,
    INVALID_SEARCH_PARAMETERS,
    INVALID_DOMAIN_SUFFIX,
    MUTUALLY_EXCLUSIVE_SEARCH_PARAMETERS_IN_QUERY,
    SERVICE_UNAVAILABLE,
    INVALID_URL_IN_SEARCH_PARAMETER,
    TOO_MANY_RESULTS_REQUESTED,
    NO_PAGING_IN_SELECTOR,
    INVALID_INCLUDED_EXCLUDED_KEYWORDS
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "TrafficEstimatorServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Estimate))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(EstimateRequest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class TrafficEstimatorService : AdWordsSoapClient, ITrafficEstimatorService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public TrafficEstimatorService() {
      this.Url = "https://adwords.google.com/api/adwords/o/v201409/TrafficEstimatorService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/o/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/o/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual TrafficEstimatorResult get(TrafficEstimatorSelector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((TrafficEstimatorResult) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class StatsEstimate {
    private Money averageCpcField;

    private double averagePositionField;

    private bool averagePositionFieldSpecified;

    private double clickThroughRateField;

    private bool clickThroughRateFieldSpecified;

    private float clicksPerDayField;

    private bool clicksPerDayFieldSpecified;

    private float impressionsPerDayField;

    private bool impressionsPerDayFieldSpecified;

    private Money totalCostField;

    public Money averageCpc {
      get { return this.averageCpcField; }
      set { this.averageCpcField = value; }
    }

    public double averagePosition {
      get { return this.averagePositionField; }
      set {
        this.averagePositionField = value;
        this.averagePositionSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool averagePositionSpecified {
      get { return this.averagePositionFieldSpecified; }
      set { this.averagePositionFieldSpecified = value; }
    }

    public double clickThroughRate {
      get { return this.clickThroughRateField; }
      set {
        this.clickThroughRateField = value;
        this.clickThroughRateSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clickThroughRateSpecified {
      get { return this.clickThroughRateFieldSpecified; }
      set { this.clickThroughRateFieldSpecified = value; }
    }

    public float clicksPerDay {
      get { return this.clicksPerDayField; }
      set {
        this.clicksPerDayField = value;
        this.clicksPerDaySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool clicksPerDaySpecified {
      get { return this.clicksPerDayFieldSpecified; }
      set { this.clicksPerDayFieldSpecified = value; }
    }

    public float impressionsPerDay {
      get { return this.impressionsPerDayField; }
      set {
        this.impressionsPerDayField = value;
        this.impressionsPerDaySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsPerDaySpecified {
      get { return this.impressionsPerDayFieldSpecified; }
      set { this.impressionsPerDayFieldSpecified = value; }
    }

    public Money totalCost {
      get { return this.totalCostField; }
      set { this.totalCostField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignEstimate))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordEstimate))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupEstimate))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class Estimate {
    private string estimateTypeField;

    [System.Xml.Serialization.XmlElementAttribute("Estimate.Type")]
    public string EstimateType {
      get { return this.estimateTypeField; }
      set { this.estimateTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class CampaignEstimate : Estimate {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private AdGroupEstimate[] adGroupEstimatesField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adGroupEstimates")]
    public AdGroupEstimate[] adGroupEstimates {
      get { return this.adGroupEstimatesField; }
      set { this.adGroupEstimatesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class AdGroupEstimate : Estimate {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private KeywordEstimate[] keywordEstimatesField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywordEstimates")]
    public KeywordEstimate[] keywordEstimates {
      get { return this.keywordEstimatesField; }
      set { this.keywordEstimatesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class KeywordEstimate : Estimate {
    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    private StatsEstimate minField;

    private StatsEstimate maxField;

    public long criterionId {
      get { return this.criterionIdField; }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get { return this.criterionIdFieldSpecified; }
      set { this.criterionIdFieldSpecified = value; }
    }

    public StatsEstimate min {
      get { return this.minField; }
      set { this.minField = value; }
    }

    public StatsEstimate max {
      get { return this.maxField; }
      set { this.maxField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TrafficEstimatorResult {
    private CampaignEstimate[] campaignEstimatesField;


    [System.Xml.Serialization.XmlElementAttribute("campaignEstimates")]
    public CampaignEstimate[] campaignEstimates {
      get { return this.campaignEstimatesField; }
      set { this.campaignEstimatesField = value; }
    }

  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignEstimateRequest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(KeywordEstimateRequest))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(AdGroupEstimateRequest))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public abstract partial class EstimateRequest {
    private string estimateRequestTypeField;

    [System.Xml.Serialization.XmlElementAttribute("EstimateRequest.Type")]
    public string EstimateRequestType {
      get { return this.estimateRequestTypeField; }
      set { this.estimateRequestTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class CampaignEstimateRequest : EstimateRequest {
    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private AdGroupEstimateRequest[] adGroupEstimateRequestsField;

    private Criterion[] criteriaField;

    private NetworkSetting networkSettingField;

    private Money dailyBudgetField;

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("adGroupEstimateRequests")]
    public AdGroupEstimateRequest[] adGroupEstimateRequests {
      get { return this.adGroupEstimateRequestsField; }
      set { this.adGroupEstimateRequestsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("criteria")]
    public Criterion[] criteria {
      get { return this.criteriaField; }
      set { this.criteriaField = value; }
    }

    public NetworkSetting networkSetting {
      get { return this.networkSettingField; }
      set { this.networkSettingField = value; }
    }

    public Money dailyBudget {
      get { return this.dailyBudgetField; }
      set { this.dailyBudgetField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class AdGroupEstimateRequest : EstimateRequest {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private KeywordEstimateRequest[] keywordEstimateRequestsField;

    private Money maxCpcField;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("keywordEstimateRequests")]
    public KeywordEstimateRequest[] keywordEstimateRequests {
      get { return this.keywordEstimateRequestsField; }
      set { this.keywordEstimateRequestsField = value; }
    }

    public Money maxCpc {
      get { return this.maxCpcField; }
      set { this.maxCpcField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class KeywordEstimateRequest : EstimateRequest {
    private Keyword keywordField;

    private Money maxCpcField;

    private bool isNegativeField;

    private bool isNegativeFieldSpecified;

    public Keyword keyword {
      get { return this.keywordField; }
      set { this.keywordField = value; }
    }

    public Money maxCpc {
      get { return this.maxCpcField; }
      set { this.maxCpcField = value; }
    }

    public bool isNegative {
      get { return this.isNegativeField; }
      set {
        this.isNegativeField = value;
        this.isNegativeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isNegativeSpecified {
      get { return this.isNegativeFieldSpecified; }
      set { this.isNegativeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/o/v201409")]
  public partial class TrafficEstimatorSelector {
    private CampaignEstimateRequest[] campaignEstimateRequestsField;


    [System.Xml.Serialization.XmlElementAttribute("campaignEstimateRequests")]
    public CampaignEstimateRequest[] campaignEstimateRequests {
      get { return this.campaignEstimateRequestsField; }
      set { this.campaignEstimateRequestsField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdwordsUserListServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdwordsUserListService : AdWordsSoapClient, IAdwordsUserListService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdwordsUserListService() {
      this.Url = "https://adwords.google.com/api/adwords/rm/v201409/AdwordsUserListService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/rm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/rm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual UserListPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((UserListPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/rm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/rm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual UserListReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
UserListOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((UserListReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class UserListReturnValue : ListReturnValue {
    private UserList[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public UserList[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimilarUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(RuleBasedUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpressionRuleUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateSpecificRuleUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(BasicUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(LogicalUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExternalRemarketingUserList))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class UserList {
    private long idField;

    private bool idFieldSpecified;

    private bool isReadOnlyField;

    private bool isReadOnlyFieldSpecified;

    private string nameField;

    private string descriptionField;

    private UserListMembershipStatus statusField;

    private bool statusFieldSpecified;

    private string integrationCodeField;

    private AccessReason accessReasonField;

    private bool accessReasonFieldSpecified;

    private AccountUserListStatus accountUserListStatusField;

    private bool accountUserListStatusFieldSpecified;

    private long membershipLifeSpanField;

    private bool membershipLifeSpanFieldSpecified;

    private long sizeField;

    private bool sizeFieldSpecified;

    private SizeRange sizeRangeField;

    private bool sizeRangeFieldSpecified;

    private long sizeForSearchField;

    private bool sizeForSearchFieldSpecified;

    private SizeRange sizeRangeForSearchField;

    private bool sizeRangeForSearchFieldSpecified;

    private UserListType listTypeField;

    private bool listTypeFieldSpecified;

    private string userListTypeField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public bool isReadOnly {
      get { return this.isReadOnlyField; }
      set {
        this.isReadOnlyField = value;
        this.isReadOnlySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool isReadOnlySpecified {
      get { return this.isReadOnlyFieldSpecified; }
      set { this.isReadOnlyFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public string description {
      get { return this.descriptionField; }
      set { this.descriptionField = value; }
    }

    public UserListMembershipStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public string integrationCode {
      get { return this.integrationCodeField; }
      set { this.integrationCodeField = value; }
    }

    public AccessReason accessReason {
      get { return this.accessReasonField; }
      set {
        this.accessReasonField = value;
        this.accessReasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool accessReasonSpecified {
      get { return this.accessReasonFieldSpecified; }
      set { this.accessReasonFieldSpecified = value; }
    }

    public AccountUserListStatus accountUserListStatus {
      get { return this.accountUserListStatusField; }
      set {
        this.accountUserListStatusField = value;
        this.accountUserListStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool accountUserListStatusSpecified {
      get { return this.accountUserListStatusFieldSpecified; }
      set { this.accountUserListStatusFieldSpecified = value; }
    }

    public long membershipLifeSpan {
      get { return this.membershipLifeSpanField; }
      set {
        this.membershipLifeSpanField = value;
        this.membershipLifeSpanSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool membershipLifeSpanSpecified {
      get { return this.membershipLifeSpanFieldSpecified; }
      set { this.membershipLifeSpanFieldSpecified = value; }
    }

    public long size {
      get { return this.sizeField; }
      set {
        this.sizeField = value;
        this.sizeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sizeSpecified {
      get { return this.sizeFieldSpecified; }
      set { this.sizeFieldSpecified = value; }
    }

    public SizeRange sizeRange {
      get { return this.sizeRangeField; }
      set {
        this.sizeRangeField = value;
        this.sizeRangeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sizeRangeSpecified {
      get { return this.sizeRangeFieldSpecified; }
      set { this.sizeRangeFieldSpecified = value; }
    }

    public long sizeForSearch {
      get { return this.sizeForSearchField; }
      set {
        this.sizeForSearchField = value;
        this.sizeForSearchSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sizeForSearchSpecified {
      get { return this.sizeForSearchFieldSpecified; }
      set { this.sizeForSearchFieldSpecified = value; }
    }

    public SizeRange sizeRangeForSearch {
      get { return this.sizeRangeForSearchField; }
      set {
        this.sizeRangeForSearchField = value;
        this.sizeRangeForSearchSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sizeRangeForSearchSpecified {
      get { return this.sizeRangeForSearchFieldSpecified; }
      set { this.sizeRangeForSearchFieldSpecified = value; }
    }

    public UserListType listType {
      get { return this.listTypeField; }
      set {
        this.listTypeField = value;
        this.listTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool listTypeSpecified {
      get { return this.listTypeFieldSpecified; }
      set { this.listTypeFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("UserList.Type")]
    public string UserListType {
      get { return this.userListTypeField; }
      set { this.userListTypeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum UserListMembershipStatus {
    OPEN,
    CLOSED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum AccessReason {
    OWNED,
    SHARED,
    LICENSED,
    SUBSCRIBED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum AccountUserListStatus {
    ACTIVE,
    INACTIVE
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum SizeRange {
    LESS_THAN_FIVE_HUNDRED,
    LESS_THAN_ONE_THOUSAND,
    ONE_THOUSAND_TO_TEN_THOUSAND,
    TEN_THOUSAND_TO_FIFTY_THOUSAND,
    FIFTY_THOUSAND_TO_ONE_HUNDRED_THOUSAND,
    ONE_HUNDRED_THOUSAND_TO_THREE_HUNDRED_THOUSAND,
    THREE_HUNDRED_THOUSAND_TO_FIVE_HUNDRED_THOUSAND,
    FIVE_HUNDRED_THOUSAND_TO_ONE_MILLION,
    ONE_MILLION_TO_TWO_MILLION,
    TWO_MILLION_TO_THREE_MILLION,
    THREE_MILLION_TO_FIVE_MILLION,
    FIVE_MILLION_TO_TEN_MILLION,
    TEN_MILLION_TO_TWENTY_MILLION,
    TWENTY_MILLION_TO_THIRTY_MILLION,
    THIRTY_MILLION_TO_FIFTY_MILLION,
    OVER_FIFTY_MILLION
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum UserListType {
    UNKNOWN,
    REMARKETING,
    LOGICAL,
    EXTERNAL_REMARKETING,
    RULE_BASED,
    SIMILAR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class SimilarUserList : UserList {
    private long seedUserListIdField;

    private bool seedUserListIdFieldSpecified;

    private string seedUserListNameField;

    private string seedUserListDescriptionField;

    private UserListMembershipStatus seedUserListStatusField;

    private bool seedUserListStatusFieldSpecified;

    private long seedListSizeField;

    private bool seedListSizeFieldSpecified;

    public long seedUserListId {
      get { return this.seedUserListIdField; }
      set {
        this.seedUserListIdField = value;
        this.seedUserListIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool seedUserListIdSpecified {
      get { return this.seedUserListIdFieldSpecified; }
      set { this.seedUserListIdFieldSpecified = value; }
    }

    public string seedUserListName {
      get { return this.seedUserListNameField; }
      set { this.seedUserListNameField = value; }
    }

    public string seedUserListDescription {
      get { return this.seedUserListDescriptionField; }
      set { this.seedUserListDescriptionField = value; }
    }

    public UserListMembershipStatus seedUserListStatus {
      get { return this.seedUserListStatusField; }
      set {
        this.seedUserListStatusField = value;
        this.seedUserListStatusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool seedUserListStatusSpecified {
      get { return this.seedUserListStatusFieldSpecified; }
      set { this.seedUserListStatusFieldSpecified = value; }
    }

    public long seedListSize {
      get { return this.seedListSizeField; }
      set {
        this.seedListSizeField = value;
        this.seedListSizeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool seedListSizeSpecified {
      get { return this.seedListSizeFieldSpecified; }
      set { this.seedListSizeFieldSpecified = value; }
    }
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpressionRuleUserList))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(DateSpecificRuleUserList))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class RuleBasedUserList : UserList {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class ExpressionRuleUserList : RuleBasedUserList {
    private Rule ruleField;

    public Rule rule {
      get { return this.ruleField; }
      set { this.ruleField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class Rule {
    private RuleItemGroup[] groupsField;


    [System.Xml.Serialization.XmlElementAttribute("groups")]
    public RuleItemGroup[] groups {
      get { return this.groupsField; }
      set { this.groupsField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class RuleItemGroup {
    private RuleItem[] itemsField;


    [System.Xml.Serialization.XmlElementAttribute("items")]
    public RuleItem[] items {
      get { return this.itemsField; }
      set { this.itemsField = value; }
    }

  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class RuleItem {
    private object itemField;

    [System.Xml.Serialization.XmlElementAttribute("DateRuleItem", typeof(DateRuleItem))]
    [System.Xml.Serialization.XmlElementAttribute("NumberRuleItem", typeof(NumberRuleItem))]
    [System.Xml.Serialization.XmlElementAttribute("StringRuleItem", typeof(StringRuleItem))]
    public object Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class DateRuleItem {
    private DateKey keyField;

    private DateRuleItemDateOperator opField;

    private bool opFieldSpecified;

    private string valueField;

    public DateKey key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }

    public DateRuleItemDateOperator op {
      get { return this.opField; }
      set {
        this.opField = value;
        this.opSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool opSpecified {
      get { return this.opFieldSpecified; }
      set { this.opFieldSpecified = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class DateKey {
    private string nameField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "DateRuleItem.DateOperator", Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum DateRuleItemDateOperator {
    UNKNOWN,
    EQUALS,
    NOT_EQUAL,
    BEFORE,
    AFTER
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class NumberRuleItem {
    private NumberKey keyField;

    private NumberRuleItemNumberOperator opField;

    private bool opFieldSpecified;

    private double valueField;

    private bool valueFieldSpecified;

    public NumberKey key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }

    public NumberRuleItemNumberOperator op {
      get { return this.opField; }
      set {
        this.opField = value;
        this.opSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool opSpecified {
      get { return this.opFieldSpecified; }
      set { this.opFieldSpecified = value; }
    }

    public double value {
      get { return this.valueField; }
      set {
        this.valueField = value;
        this.valueSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool valueSpecified {
      get { return this.valueFieldSpecified; }
      set { this.valueFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class NumberKey {
    private string nameField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "NumberRuleItem.NumberOperator", Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum NumberRuleItemNumberOperator {
    UNKNOWN,
    GREATER_THAN,
    GREATER_THAN_OR_EQUAL,
    EQUALS,
    NOT_EQUAL,
    LESS_THAN,
    LESS_THAN_OR_EQUAL
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class StringRuleItem {
    private StringKey keyField;

    private StringRuleItemStringOperator opField;

    private bool opFieldSpecified;

    private string valueField;

    public StringKey key {
      get { return this.keyField; }
      set { this.keyField = value; }
    }

    public StringRuleItemStringOperator op {
      get { return this.opField; }
      set {
        this.opField = value;
        this.opSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool opSpecified {
      get { return this.opFieldSpecified; }
      set { this.opFieldSpecified = value; }
    }

    public string value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class StringKey {
    private string nameField;

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "StringRuleItem.StringOperator", Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum StringRuleItemStringOperator {
    UNKNOWN,
    CONTAINS,
    EQUALS,
    STARTS_WITH,
    ENDS_WITH,
    NOT_EQUAL,
    NOT_CONTAIN,
    NOT_START_WITH,
    NOT_END_WITH
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class DateSpecificRuleUserList : RuleBasedUserList {
    private Rule ruleField;

    private string startDateField;

    private string endDateField;

    public Rule rule {
      get { return this.ruleField; }
      set { this.ruleField = value; }
    }

    public string startDate {
      get { return this.startDateField; }
      set { this.startDateField = value; }
    }

    public string endDate {
      get { return this.endDateField; }
      set { this.endDateField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class BasicUserList : UserList {
    private UserListConversionType[] conversionTypesField;

    [System.Xml.Serialization.XmlElementAttribute("conversionTypes")]
    public UserListConversionType[] conversionTypes {
      get { return this.conversionTypesField; }
      set { this.conversionTypesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class UserListConversionType {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private UserListConversionTypeCategory categoryField;

    private bool categoryFieldSpecified;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public UserListConversionTypeCategory category {
      get { return this.categoryField; }
      set {
        this.categoryField = value;
        this.categorySpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool categorySpecified {
      get { return this.categoryFieldSpecified; }
      set { this.categoryFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UserListConversionType.Category", Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum UserListConversionTypeCategory {
    BOOMERANG_EVENT,
    OTHER
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class LogicalUserList : UserList {
    private UserListLogicalRule[] rulesField;

    [System.Xml.Serialization.XmlElementAttribute("rules")]
    public UserListLogicalRule[] rules {
      get { return this.rulesField; }
      set { this.rulesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class UserListLogicalRule {
    private UserListLogicalRuleOperator operatorField;

    private bool operatorFieldSpecified;

    private LogicalUserListOperand[] ruleOperandsField;

    public UserListLogicalRuleOperator @operator {
      get { return this.operatorField; }
      set {
        this.operatorField = value;
        this.operatorSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool operatorSpecified {
      get { return this.operatorFieldSpecified; }
      set { this.operatorFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ruleOperands")]
    public LogicalUserListOperand[] ruleOperands {
      get { return this.ruleOperandsField; }
      set { this.ruleOperandsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UserListLogicalRule.Operator", Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum UserListLogicalRuleOperator {
    ALL,
    ANY,
    NONE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class LogicalUserListOperand {
    private UserList itemField;

    [System.Xml.Serialization.XmlElementAttribute("UserList")]
    public UserList Item {
      get { return this.itemField; }
      set { this.itemField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class ExternalRemarketingUserList : UserList {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class UserListOperation : Operation {
    private UserList operandField;

    public UserList operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class UserListPage : Page {
    private UserList[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public UserList[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public partial class UserListError : ApiError {
    private UserListErrorReason reasonField;

    private bool reasonFieldSpecified;

    public UserListErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "UserListError.Reason", Namespace = "https://adwords.google.com/api/adwords/rm/v201409")]
  public enum UserListErrorReason {
    EXTERNAL_REMARKETING_USER_LIST_MUTATE_NOT_SUPPORTED,
    CONCRETE_TYPE_REQUIRED,
    CONVERSION_TYPE_ID_REQUIRED,
    DUPLICATE_CONVERSION_TYPES,
    INVALID_CONVERSION_TYPE,
    INVALID_DESCRIPTION,
    INVALID_NAME,
    INVALID_TYPE,
    INVALID_USER_LIST_LOGICAL_RULE_OPERAND,
    NAME_ALREADY_USED,
    NEW_CONVERSION_TYPE_NAME_REQUIRED,
    OWNERSHIP_REQUIRED_FOR_SET,
    REMOVE_NOT_SUPPORTED,
    USER_LIST_MUTATE_NOT_SUPPORTED,
    INVALID_RULE,
    INVALID_DATE_RANGE,
    USER_LIST_SERVICE_ERROR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ExpressBusinessServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ExpressBusinessService : AdWordsSoapClient, IExpressBusinessService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ExpressBusinessService() {
      this.Url = "https://adwords.google.com/api/adwords/express/v201409/ExpressBusinessService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/express/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/express/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ExpressBusinessPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((ExpressBusinessPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/express/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/express/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ExpressBusiness[] mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
ExpressBusinessOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((ExpressBusiness[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class ExpressBusinessOperation : Operation {
    private ExpressBusiness operandField;

    public ExpressBusiness operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class ExpressBusiness {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private ExpressBusinessStatus statusField;

    private bool statusFieldSpecified;

    private Address addressField;

    private GeoPoint geoPointField;

    private PhoneNumber phoneNumberField;

    private string websiteField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public ExpressBusinessStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public Address address {
      get { return this.addressField; }
      set { this.addressField = value; }
    }

    public GeoPoint geoPoint {
      get { return this.geoPointField; }
      set { this.geoPointField = value; }
    }

    public PhoneNumber phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }

    public string website {
      get { return this.websiteField; }
      set { this.websiteField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ExpressBusiness.Status", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public enum ExpressBusinessStatus {
    ENABLED,
    REMOVED
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class PhoneNumber {
    private ExpressRegionCode regionCodeField;

    private bool regionCodeFieldSpecified;

    private string numberField;

    public ExpressRegionCode regionCode {
      get { return this.regionCodeField; }
      set {
        this.regionCodeField = value;
        this.regionCodeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool regionCodeSpecified {
      get { return this.regionCodeFieldSpecified; }
      set { this.regionCodeFieldSpecified = value; }
    }

    public string number {
      get { return this.numberField; }
      set { this.numberField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public enum ExpressRegionCode {
    AC,
    AD,
    AE,
    AF,
    AG,
    AI,
    AL,
    AM,
    AN,
    AO,
    AQ,
    AR,
    AS,
    AT,
    AU,
    AW,
    AX,
    AZ,
    BA,
    BB,
    BD,
    BE,
    BF,
    BG,
    BH,
    BI,
    BJ,
    BL,
    BM,
    BN,
    BO,
    BQ,
    BR,
    BS,
    BT,
    BU,
    BV,
    BW,
    BY,
    BZ,
    CA,
    CC,
    CD,
    CF,
    CG,
    CH,
    CI,
    CK,
    CL,
    CM,
    CN,
    CO,
    CP,
    CR,
    CS,
    CU,
    CV,
    CW,
    CX,
    CY,
    CZ,
    DD,
    DE,
    DG,
    DJ,
    DK,
    DM,
    DO,
    DZ,
    EA,
    EC,
    EE,
    EG,
    EH,
    ER,
    ES,
    ET,
    EU,
    FI,
    FJ,
    FK,
    FM,
    FO,
    FR,
    FX,
    GA,
    GB,
    GD,
    GE,
    GF,
    GG,
    GH,
    GI,
    GL,
    GM,
    GN,
    GP,
    GQ,
    GR,
    GS,
    GT,
    GU,
    GW,
    GY,
    HK,
    HM,
    HN,
    HR,
    HT,
    HU,
    IC,
    ID,
    IE,
    IL,
    IM,
    IN,
    IO,
    IQ,
    IR,
    IS,
    IT,
    JE,
    JM,
    JO,
    JP,
    KE,
    KG,
    KH,
    KI,
    KM,
    KN,
    KP,
    KR,
    KW,
    KY,
    KZ,
    LA,
    LB,
    LC,
    LI,
    LK,
    LR,
    LS,
    LT,
    LU,
    LV,
    LY,
    MA,
    MC,
    MD,
    ME,
    MF,
    MG,
    MH,
    MK,
    ML,
    MM,
    MN,
    MO,
    MP,
    MQ,
    MR,
    MS,
    MT,
    MU,
    MV,
    MW,
    MX,
    MY,
    MZ,
    NA,
    NC,
    NE,
    NF,
    NG,
    NI,
    NL,
    NO,
    NP,
    NR,
    NT,
    NU,
    NZ,
    OM,
    PA,
    PE,
    PF,
    PG,
    PH,
    PK,
    PL,
    PM,
    PN,
    PR,
    PS,
    PT,
    PW,
    PY,
    QA,
    QO,
    QU,
    RE,
    RO,
    RS,
    RU,
    RW,
    SA,
    SB,
    SC,
    SD,
    SE,
    SG,
    SH,
    SI,
    SJ,
    SK,
    SL,
    SM,
    SN,
    SO,
    SR,
    SS,
    ST,
    SU,
    SV,
    SX,
    SY,
    SZ,
    TA,
    TC,
    TD,
    TF,
    TG,
    TH,
    TJ,
    TK,
    TL,
    TM,
    TN,
    TO,
    TP,
    TR,
    TT,
    TV,
    TW,
    TZ,
    UA,
    UG,
    UM,
    US,
    UY,
    UZ,
    VA,
    VC,
    VE,
    VG,
    VI,
    VN,
    VU,
    WF,
    WS,
    XA,
    XB,
    XC,
    XK,
    YD,
    YE,
    YT,
    YU,
    ZA,
    ZM,
    ZR,
    ZW,
    ZZ,
    UN001,
    UN002,
    UN003,
    UN005,
    UN009,
    UN011,
    UN013,
    UN014,
    UN015,
    UN017,
    UN018,
    UN019,
    UN021,
    UN029,
    UN030,
    UN034,
    UN035,
    UN039,
    UN053,
    UN054,
    UN057,
    UN061,
    UN142,
    UN143,
    UN145,
    UN150,
    UN151,
    UN154,
    UN155,
    UN419
  }


  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpressBusinessPage))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(PromotionPage))]
  public abstract partial class ExpressNoStatsPage : Page {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class ExpressBusinessPage : ExpressNoStatsPage {
    private ExpressBusiness[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public ExpressBusiness[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class ExpressBusinessError : ApiError {
    private ExpressBusinessErrorReason reasonField;

    private bool reasonFieldSpecified;

    public ExpressBusinessErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "ExpressBusinessError.Reason", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public enum ExpressBusinessErrorReason {
    INVALID_WEBSITE,
    INVALID_ADDRESS,
    INVALID_PHONE_NUMBER,
    PREMIUM_RATE_PHONE_NUMBER_NOT_ALLOWED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "BudgetSuggestionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoapHeader))]
  public partial class BudgetSuggestionService : AdWordsSoapClient, IBudgetSuggestionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public BudgetSuggestionService() {
      this.Url = "https://adwords.google.com/api/adwords/express/v201409/BudgetSuggestionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/express/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/express/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BudgetSuggestion get(BudgetSuggestionSelector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((BudgetSuggestion) (results[0]));
    }
  }









  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class BudgetSuggestion {
    private Money cpcField;

    private Money minCpcField;

    private Money maxCpcField;

    private Money cpmField;

    private Money suggestedBudgetField;

    private Money minBudgetField;

    private Money maxBudgetField;

    private Money[] budgetQuantilesField;

    private long impressionsField;

    private bool impressionsFieldSpecified;

    public Money cpc {
      get { return this.cpcField; }
      set { this.cpcField = value; }
    }

    public Money minCpc {
      get { return this.minCpcField; }
      set { this.minCpcField = value; }
    }

    public Money maxCpc {
      get { return this.maxCpcField; }
      set { this.maxCpcField = value; }
    }

    public Money cpm {
      get { return this.cpmField; }
      set { this.cpmField = value; }
    }

    public Money suggestedBudget {
      get { return this.suggestedBudgetField; }
      set { this.suggestedBudgetField = value; }
    }

    public Money minBudget {
      get { return this.minBudgetField; }
      set { this.minBudgetField = value; }
    }

    public Money maxBudget {
      get { return this.maxBudgetField; }
      set { this.maxBudgetField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("budgetQuantiles")]
    public Money[] budgetQuantiles {
      get { return this.budgetQuantilesField; }
      set { this.budgetQuantilesField = value; }
    }

    public long impressions {
      get { return this.impressionsField; }
      set {
        this.impressionsField = value;
        this.impressionsSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool impressionsSpecified {
      get { return this.impressionsFieldSpecified; }
      set { this.impressionsFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class NegativeKeyword : Keyword {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class ProductService : Criterion, IProductService {
    private string textField;

    private string localeField;

    public virtual string text {
      get { return this.textField; }
      set { this.textField = value; }
    }

    public virtual string locale {
      get { return this.localeField; }
      set { this.localeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class NegativeCriterion : Criterion {
    private Criterion criterionField;

    public Criterion criterion {
      get { return this.criterionField; }
      set { this.criterionField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class KeywordSet : Criterion {
    private string keywordSetIdField;

    private string nameField;

    private bool deprecatedField;

    private bool deprecatedFieldSpecified;

    public string keywordSetId {
      get { return this.keywordSetIdField; }
      set { this.keywordSetIdField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public bool deprecated {
      get { return this.deprecatedField; }
      set {
        this.deprecatedField = value;
        this.deprecatedSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool deprecatedSpecified {
      get { return this.deprecatedFieldSpecified; }
      set { this.deprecatedFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class BudgetSuggestionSelector {
    private Criterion[] criteriaField;

    private CurrencyCode currencyCodeField;

    private bool currencyCodeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("criteria")]
    public Criterion[] criteria {
      get { return this.criteriaField; }
      set { this.criteriaField = value; }
    }

    public CurrencyCode currencyCode {
      get { return this.currencyCodeField; }
      set {
        this.currencyCodeField = value;
        this.currencyCodeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool currencyCodeSpecified {
      get { return this.currencyCodeFieldSpecified; }
      set { this.currencyCodeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public enum CurrencyCode {
    ADP,
    AED,
    AFA,
    AFN,
    ALK,
    ALL,
    AMD,
    ANG,
    AOA,
    AOK,
    AON,
    AOR,
    ARA,
    ARL,
    ARM,
    ARP,
    ARS,
    ATS,
    AUD,
    AWG,
    AZM,
    AZN,
    BAD,
    BAM,
    BAN,
    BBD,
    BDT,
    BEF,
    BGL,
    BGM,
    BGN,
    BGO,
    BHD,
    BIF,
    BMD,
    BND,
    BOB,
    BOL,
    BOP,
    BRB,
    BRC,
    BRE,
    BRL,
    BRN,
    BRR,
    BRZ,
    BSD,
    BTN,
    BUK,
    BWP,
    BYB,
    BYR,
    BZD,
    CAD,
    CDF,
    CHF,
    CLE,
    CLF,
    CLP,
    CNY,
    COP,
    CRC,
    CSD,
    CSK,
    CUC,
    CUP,
    CVE,
    CYP,
    CZK,
    DDM,
    DEM,
    DJF,
    DKK,
    DOP,
    DZD,
    ECS,
    EEK,
    EGP,
    ERN,
    ESP,
    ETB,
    EUR,
    FIM,
    FJD,
    FKP,
    FRF,
    GBP,
    GEK,
    GEL,
    GHC,
    GHP,
    GHS,
    GIP,
    GMD,
    GNF,
    GNS,
    GQE,
    GRD,
    GTQ,
    GWE,
    GWP,
    GYD,
    HKD,
    HNL,
    HRD,
    HRK,
    HTG,
    HUF,
    IDR,
    IEP,
    ILP,
    ILR,
    ILS,
    INR,
    IQD,
    IRR,
    ISJ,
    ISK,
    ITL,
    JMD,
    JOD,
    JPY,
    KES,
    KGS,
    KHR,
    KMF,
    KPW,
    KRH,
    KRO,
    KRW,
    KWD,
    KYD,
    KZT,
    LAK,
    LBP,
    LKR,
    LRD,
    LSL,
    LTL,
    LTT,
    LUF,
    LVL,
    LVR,
    LYD,
    MAD,
    MAF,
    MCF,
    MDC,
    MDL,
    MGA,
    MGF,
    MKD,
    MKN,
    MLF,
    MMK,
    MNT,
    MOP,
    MRO,
    MTL,
    MTP,
    MUR,
    MVR,
    MWK,
    MXN,
    MXP,
    MYR,
    MZE,
    MZM,
    MZN,
    NAD,
    NGN,
    NIC,
    NIO,
    NLG,
    NOK,
    NPR,
    NZD,
    OMR,
    PAB,
    PEI,
    PEN,
    PES,
    PGK,
    PHP,
    PKR,
    PLN,
    PLZ,
    PTE,
    PYG,
    QAR,
    RHD,
    ROL,
    RON,
    RSD,
    RUB,
    RUR,
    RWF,
    SAR,
    SBD,
    SCR,
    SDD,
    SDG,
    SDP,
    SEK,
    SGD,
    SHP,
    SIT,
    SKK,
    SLL,
    SOS,
    SRD,
    SRG,
    SSP,
    STD,
    SUR,
    SVC,
    SYP,
    SZL,
    THB,
    TJR,
    TJS,
    TMM,
    TMT,
    TND,
    TOP,
    TPE,
    TRL,
    TRY,
    TTD,
    TWD,
    TZS,
    UAH,
    UAK,
    UGS,
    UGX,
    USD,
    UYP,
    UYU,
    UZS,
    VEB,
    VEF,
    VND,
    VNN,
    VUV,
    WST,
    XAF,
    XCD,
    XOF,
    XPF,
    XXX,
    YDD,
    YER,
    YUD,
    YUM,
    YUN,
    YUR,
    ZAR,
    ZMK,
    ZMW,
    ZRN,
    ZRZ,
    ZWD,
    ZWL,
    ZWR
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "PromotionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(SoapHeader))]
  public partial class PromotionService : AdWordsSoapClient, IPromotionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public PromotionService() {
      this.Url = "https://adwords.google.com/api/adwords/express/v201409/PromotionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/express/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/express/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual PromotionPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((PromotionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/express/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/express/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual Promotion[] mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
PromotionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((Promotion[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class PromotionOperation : Operation {
    private Promotion operandField;

    public Promotion operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class Promotion {
    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private PromotionStatus statusField;

    private bool statusFieldSpecified;

    private Creative[] creativesField;

    private string destinationUrlField;

    private PhoneNumber phoneNumberField;

    private bool streetAddressVisibleField;

    private bool streetAddressVisibleFieldSpecified;

    private bool callTrackingEnabledField;

    private bool callTrackingEnabledFieldSpecified;

    private Money budgetField;

    private Criterion[] criteriaField;

    private long[] campaignIdsField;

    private Money remainingBudgetField;

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public PromotionStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("creatives")]
    public Creative[] creatives {
      get { return this.creativesField; }
      set { this.creativesField = value; }
    }

    public string destinationUrl {
      get { return this.destinationUrlField; }
      set { this.destinationUrlField = value; }
    }

    public PhoneNumber phoneNumber {
      get { return this.phoneNumberField; }
      set { this.phoneNumberField = value; }
    }

    public bool streetAddressVisible {
      get { return this.streetAddressVisibleField; }
      set {
        this.streetAddressVisibleField = value;
        this.streetAddressVisibleSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool streetAddressVisibleSpecified {
      get { return this.streetAddressVisibleFieldSpecified; }
      set { this.streetAddressVisibleFieldSpecified = value; }
    }

    public bool callTrackingEnabled {
      get { return this.callTrackingEnabledField; }
      set {
        this.callTrackingEnabledField = value;
        this.callTrackingEnabledSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool callTrackingEnabledSpecified {
      get { return this.callTrackingEnabledFieldSpecified; }
      set { this.callTrackingEnabledFieldSpecified = value; }
    }

    public Money budget {
      get { return this.budgetField; }
      set { this.budgetField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("criteria")]
    public Criterion[] criteria {
      get { return this.criteriaField; }
      set { this.criteriaField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("campaignIds")]
    public long[] campaignIds {
      get { return this.campaignIdsField; }
      set { this.campaignIdsField = value; }
    }

    public Money remainingBudget {
      get { return this.remainingBudgetField; }
      set { this.remainingBudgetField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "Promotion.Status", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public enum PromotionStatus {
    DRAFT,
    ENABLED,
    PAUSED,
    REMOVED,
    UPGRADED_TO_ADWORDS
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class Creative {
    private string headlineField;

    private string line1Field;

    private string line2Field;

    public string headline {
      get { return this.headlineField; }
      set { this.headlineField = value; }
    }

    public string line1 {
      get { return this.line1Field; }
      set { this.line1Field = value; }
    }

    public string line2 {
      get { return this.line2Field; }
      set { this.line2Field = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class PromotionPage : ExpressNoStatsPage {
    private Promotion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Promotion[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class PromotionError : ApiError {
    private PromotionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public PromotionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "PromotionError.Reason", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public enum PromotionErrorReason {
    BUSINESS_DELETED,
    CURRENCY_NOT_SUPPORTED,
    GOOGLE_GRANT_ACCOUNT,
    AOL_ACCOUNT,
    MCC_ACCOUNT,
    INVALID_DESTINATION_URL,
    CALL_TRACKING_NOT_SUPPORTED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "ProductServiceServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Criterion))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class ProductServiceService : AdWordsSoapClient, IProductServiceService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public ProductServiceService() {
      this.Url = "https://adwords.google.com/api/adwords/express/v201409/ProductServiceService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/express/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/express/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual ProductServicePage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((ProductServicePage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/express/v201409")]
  public partial class ProductServicePage : NoStatsPage {
    private ProductService[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public ProductService[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "CampaignSharedSetServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class CampaignSharedSetService : AdWordsSoapClient, ICampaignSharedSetService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public CampaignSharedSetService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/CampaignSharedSetService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignSharedSetPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((CampaignSharedSetPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual CampaignSharedSetReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
CampaignSharedSetOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((CampaignSharedSetReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignSharedSetReturnValue : ListReturnValue {
    private CampaignSharedSet[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public CampaignSharedSet[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignSharedSet {
    private long sharedSetIdField;

    private bool sharedSetIdFieldSpecified;

    private long campaignIdField;

    private bool campaignIdFieldSpecified;

    private string sharedSetNameField;

    private SharedSetType sharedSetTypeField;

    private bool sharedSetTypeFieldSpecified;

    private string campaignNameField;

    private CampaignSharedSetStatus statusField;

    private bool statusFieldSpecified;

    public long sharedSetId {
      get { return this.sharedSetIdField; }
      set {
        this.sharedSetIdField = value;
        this.sharedSetIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sharedSetIdSpecified {
      get { return this.sharedSetIdFieldSpecified; }
      set { this.sharedSetIdFieldSpecified = value; }
    }

    public long campaignId {
      get { return this.campaignIdField; }
      set {
        this.campaignIdField = value;
        this.campaignIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool campaignIdSpecified {
      get { return this.campaignIdFieldSpecified; }
      set { this.campaignIdFieldSpecified = value; }
    }

    public string sharedSetName {
      get { return this.sharedSetNameField; }
      set { this.sharedSetNameField = value; }
    }

    public SharedSetType sharedSetType {
      get { return this.sharedSetTypeField; }
      set {
        this.sharedSetTypeField = value;
        this.sharedSetTypeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sharedSetTypeSpecified {
      get { return this.sharedSetTypeFieldSpecified; }
      set { this.sharedSetTypeFieldSpecified = value; }
    }

    public string campaignName {
      get { return this.campaignNameField; }
      set { this.campaignNameField = value; }
    }

    public CampaignSharedSetStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SharedSetType {
    NEGATIVE_KEYWORDS,
    NEGATIVE_PLACEMENTS,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignSharedSet.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignSharedSetStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignSharedSetOperation : Operation {
    private CampaignSharedSet operandField;

    public CampaignSharedSet operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignSharedSetPage : NullStatsPage {
    private CampaignSharedSet[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public CampaignSharedSet[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class CampaignSharedSetError : ApiError {
    private CampaignSharedSetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CampaignSharedSetErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CampaignSharedSetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum CampaignSharedSetErrorReason {
    CAMPAIGN_SHARED_SET_DOES_NOT_EXIST,
    SHARED_SET_NOT_ACTIVE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "SharedCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class SharedCriterionService : AdWordsSoapClient, ISharedCriterionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public SharedCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/SharedCriterionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual SharedCriterionPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((SharedCriterionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual SharedCriterionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
SharedCriterionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((SharedCriterionReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedCriterionReturnValue : ListReturnValue {
    private SharedCriterion[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public SharedCriterion[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedCriterion {
    private long sharedSetIdField;

    private bool sharedSetIdFieldSpecified;

    private Criterion criterionField;

    private bool negativeField;

    private bool negativeFieldSpecified;

    public long sharedSetId {
      get { return this.sharedSetIdField; }
      set {
        this.sharedSetIdField = value;
        this.sharedSetIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sharedSetIdSpecified {
      get { return this.sharedSetIdFieldSpecified; }
      set { this.sharedSetIdFieldSpecified = value; }
    }

    public Criterion criterion {
      get { return this.criterionField; }
      set { this.criterionField = value; }
    }

    public bool negative {
      get { return this.negativeField; }
      set {
        this.negativeField = value;
        this.negativeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool negativeSpecified {
      get { return this.negativeFieldSpecified; }
      set { this.negativeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedCriterionOperation : Operation {
    private SharedCriterion operandField;

    public SharedCriterion operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedCriterionPage : Page {
    private SharedCriterion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public SharedCriterion[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedCriterionError : ApiError {
    private SharedCriterionErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SharedCriterionErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SharedCriterionError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SharedCriterionErrorReason {
    EXCEEDS_CRITERIA_LIMIT,
    INCORRECT_CRITERION_TYPE,
    CANNOT_TARGET_AND_EXCLUDE,
    NEGATIVE_CRITERION_REQUIRED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupCriterionServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(CriterionParameter))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupCriterionService : AdWordsSoapClient, IAdGroupCriterionService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupCriterionService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/AdGroupCriterionService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupCriterionPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((AdGroupCriterionPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupCriterionReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupCriterionOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((AdGroupCriterionReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupCriterionLabelReturnValue mutateLabel([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupCriterionLabelOperation[] operations) {
      object[] results = this.Invoke("mutateLabel", new object[] { operations });
      return ((AdGroupCriterionLabelReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupCriterionPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((AdGroupCriterionPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionReturnValue : ListReturnValue {
    private AdGroupCriterion[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupCriterion[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionLabelReturnValue : ListReturnValue {
    private AdGroupCriterionLabel[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupCriterionLabel[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupCriterionPage : Page {
    private AdGroupCriterion[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupCriterion[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "SharedSetServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class SharedSetService : AdWordsSoapClient, ISharedSetService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public SharedSetService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/SharedSetService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual SharedSetPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((SharedSetPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual SharedSetReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
SharedSetOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((SharedSetReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedSetReturnValue : ListReturnValue {
    private SharedSet[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public SharedSet[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedSet {
    private long sharedSetIdField;

    private bool sharedSetIdFieldSpecified;

    private string nameField;

    private SharedSetType typeField;

    private bool typeFieldSpecified;

    private int memberCountField;

    private bool memberCountFieldSpecified;

    private int referenceCountField;

    private bool referenceCountFieldSpecified;

    private SharedSetStatus statusField;

    private bool statusFieldSpecified;

    public long sharedSetId {
      get { return this.sharedSetIdField; }
      set {
        this.sharedSetIdField = value;
        this.sharedSetIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool sharedSetIdSpecified {
      get { return this.sharedSetIdFieldSpecified; }
      set { this.sharedSetIdFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public SharedSetType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }

    public int memberCount {
      get { return this.memberCountField; }
      set {
        this.memberCountField = value;
        this.memberCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool memberCountSpecified {
      get { return this.memberCountFieldSpecified; }
      set { this.memberCountFieldSpecified = value; }
    }

    public int referenceCount {
      get { return this.referenceCountField; }
      set {
        this.referenceCountField = value;
        this.referenceCountSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool referenceCountSpecified {
      get { return this.referenceCountFieldSpecified; }
      set { this.referenceCountFieldSpecified = value; }
    }

    public SharedSetStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SharedSet.Status", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SharedSetStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedSetOperation : Operation {
    private SharedSet operandField;

    public SharedSet operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedSetPage : NullStatsPage {
    private SharedSet[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public SharedSet[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedSetError : ApiError {
    private SharedSetErrorReason reasonField;

    private bool reasonFieldSpecified;

    public SharedSetErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SharedSetError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SharedSetErrorReason {
    CUSTOMER_CANNOT_CREATE_SHARED_SET_OF_THIS_TYPE,
    DUPLICATE_NAME,
    EXCEEDS_MAX_SHARED_SETS_FOR_TYPE,
    INVALID_SET_NAME,
    SHARED_SET_REMOVED,
    SHARED_SET_IN_USE,
    TYPE_CANNOT_BE_CHANGED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "LabelServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class LabelService : AdWordsSoapClient, ILabelService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public LabelService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/LabelService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual LabelPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((LabelPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual LabelReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
LabelOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((LabelReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual LabelPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((LabelPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LabelReturnValue : ListReturnValue {
    private Label[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Label[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LabelOperation : Operation {
    private Label operandField;

    public Label operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LabelPage : NoStatsPage {
    private Label[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Label[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class LabelError : ApiError {
    private LabelErrorReason reasonField;

    private bool reasonFieldSpecified;

    public LabelErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "LabelError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum LabelErrorReason {
    DUPLICATE_NAME,
    INVALID_LABEL_NAME,
    INVALID_LABEL_TYPE,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupService : AdWordsSoapClient, IAdGroupService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/AdGroupService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((AdGroupPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((AdGroupReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupLabelReturnValue mutateLabel([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupLabelOperation[] operations) {
      object[] results = this.Invoke("mutateLabel", new object[] { operations });
      return ((AdGroupLabelReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((AdGroupPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupReturnValue : ListReturnValue {
    private AdGroup[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroup[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupLabelReturnValue : ListReturnValue {
    private AdGroupLabel[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupLabel[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupPage : Page {
    private AdGroup[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroup[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdGroupBidModifierServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdGroupBidModifierService : AdWordsSoapClient, IAdGroupBidModifierService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdGroupBidModifierService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/AdGroupBidModifierService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupBidModifierPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((AdGroupBidModifierPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupBidModifierReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdGroupBidModifierOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((AdGroupBidModifierReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdGroupBidModifierPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((AdGroupBidModifierPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupBidModifierReturnValue : ListReturnValue {
    private AdGroupBidModifier[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public AdGroupBidModifier[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdGroupBidModifierPage : Page {
    private AdGroupBidModifier[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdGroupBidModifier[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "AdParamServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class AdParamService : AdWordsSoapClient, IAdParamService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public AdParamService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/AdParamService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdParamPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((AdParamPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual AdParam[] mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
AdParamOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((AdParam[]) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdParamOperation : Operation {
    private AdParam operandField;

    public AdParam operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdParam {
    private long adGroupIdField;

    private bool adGroupIdFieldSpecified;

    private long criterionIdField;

    private bool criterionIdFieldSpecified;

    private string insertionTextField;

    private int paramIndexField;

    private bool paramIndexFieldSpecified;

    public long adGroupId {
      get { return this.adGroupIdField; }
      set {
        this.adGroupIdField = value;
        this.adGroupIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool adGroupIdSpecified {
      get { return this.adGroupIdFieldSpecified; }
      set { this.adGroupIdFieldSpecified = value; }
    }

    public long criterionId {
      get { return this.criterionIdField; }
      set {
        this.criterionIdField = value;
        this.criterionIdSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool criterionIdSpecified {
      get { return this.criterionIdFieldSpecified; }
      set { this.criterionIdFieldSpecified = value; }
    }

    public string insertionText {
      get { return this.insertionTextField; }
      set { this.insertionTextField = value; }
    }

    public int paramIndex {
      get { return this.paramIndexField; }
      set {
        this.paramIndexField = value;
        this.paramIndexSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool paramIndexSpecified {
      get { return this.paramIndexFieldSpecified; }
      set { this.paramIndexFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdParamPage {
    private AdParam[] entriesField;

    private int totalNumEntriesField;

    private bool totalNumEntriesFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public AdParam[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }

    public int totalNumEntries {
      get { return this.totalNumEntriesField; }
      set {
        this.totalNumEntriesField = value;
        this.totalNumEntriesSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool totalNumEntriesSpecified {
      get { return this.totalNumEntriesFieldSpecified; }
      set { this.totalNumEntriesFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdParamPolicyError : PolicyViolationError {
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class AdParamError : ApiError {
    private AdParamErrorReason reasonField;

    private bool reasonFieldSpecified;

    public AdParamErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "AdParamError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum AdParamErrorReason {
    AD_PARAM_CANNOT_BE_SPECIFIED_MULTIPLE_TIMES,
    AD_PARAM_DOES_NOT_EXIST,
    CRITERION_SPECIFIED_MUST_BE_KEYWORD,
    INVALID_ADGROUP_CRITERION_SPECIFIED,
    INVALID_INSERTION_TEXT_FORMAT,
    MUST_SPECIFY_ADGROUP_ID,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "BiddingStrategyServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class BiddingStrategyService : AdWordsSoapClient, IBiddingStrategyService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public BiddingStrategyService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/BiddingStrategyService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BiddingStrategyPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((BiddingStrategyPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BiddingStrategyReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
BiddingStrategyOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((BiddingStrategyReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BiddingStrategyPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((BiddingStrategyPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddingStrategyReturnValue : ListReturnValue {
    private SharedBiddingStrategy[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public SharedBiddingStrategy[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class SharedBiddingStrategy {
    private BiddingScheme biddingSchemeField;

    private long idField;

    private bool idFieldSpecified;

    private string nameField;

    private SharedBiddingStrategyBiddingStrategyStatus statusField;

    private bool statusFieldSpecified;

    private BiddingStrategyType typeField;

    private bool typeFieldSpecified;

    public BiddingScheme biddingScheme {
      get { return this.biddingSchemeField; }
      set { this.biddingSchemeField = value; }
    }

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public SharedBiddingStrategyBiddingStrategyStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public BiddingStrategyType type {
      get { return this.typeField; }
      set {
        this.typeField = value;
        this.typeSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool typeSpecified {
      get { return this.typeFieldSpecified; }
      set { this.typeFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "SharedBiddingStrategy.BiddingStrategyStatus", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum SharedBiddingStrategyBiddingStrategyStatus {
    ENABLED,
    REMOVED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddingStrategyOperation : Operation {
    private SharedBiddingStrategy operandField;

    public SharedBiddingStrategy operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddingStrategyPage : Page {
    private SharedBiddingStrategy[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public SharedBiddingStrategy[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BiddingStrategyError : ApiError {
    private BiddingStrategyErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BiddingStrategyErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BiddingStrategyError.Reason", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public enum BiddingStrategyErrorReason {
    DUPLICATE_NAME,
    CANNOT_CHANGE_BIDDING_STRATEGY_TYPE,
    CANNOT_REMOVE_ASSOCIATED_STRATEGY,
    BIDDING_STRATEGY_NOT_SUPPORTED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "BudgetOrderServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class BudgetOrderService : AdWordsSoapClient, IBudgetOrderService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public BudgetOrderService() {
      this.Url = "https://adwords.google.com/api/adwords/billing/v201409/BudgetOrderService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/billing/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/billing/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BudgetOrderPage get(Selector serviceSelector) {
      object[] results = this.Invoke("get", new object[] { serviceSelector });
      return ((BudgetOrderPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/billing/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/billing/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BillingAccount[] getBillingAccounts() {
      object[] results = this.Invoke("getBillingAccounts", new object[0]);
      return ((BillingAccount[]) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/billing/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/billing/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BudgetOrderReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
BudgetOrderOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((BudgetOrderReturnValue) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class BudgetOrderReturnValue : ListReturnValue {
    private BudgetOrder[] valueField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public BudgetOrder[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class BudgetOrder {
    private string billingAccountIdField;

    private long idField;

    private bool idFieldSpecified;

    private string billingAccountNameField;

    private string poNumberField;

    private string budgetOrderNameField;

    private string primaryBillingIdField;

    private string secondaryBillingIdField;

    private Money spendingLimitField;

    private string startDateTimeField;

    private string endDateTimeField;

    private BudgetOrderRequest lastRequestField;

    public string billingAccountId {
      get { return this.billingAccountIdField; }
      set { this.billingAccountIdField = value; }
    }

    public long id {
      get { return this.idField; }
      set {
        this.idField = value;
        this.idSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool idSpecified {
      get { return this.idFieldSpecified; }
      set { this.idFieldSpecified = value; }
    }

    public string billingAccountName {
      get { return this.billingAccountNameField; }
      set { this.billingAccountNameField = value; }
    }

    public string poNumber {
      get { return this.poNumberField; }
      set { this.poNumberField = value; }
    }

    public string budgetOrderName {
      get { return this.budgetOrderNameField; }
      set { this.budgetOrderNameField = value; }
    }

    public string primaryBillingId {
      get { return this.primaryBillingIdField; }
      set { this.primaryBillingIdField = value; }
    }

    public string secondaryBillingId {
      get { return this.secondaryBillingIdField; }
      set { this.secondaryBillingIdField = value; }
    }

    public Money spendingLimit {
      get { return this.spendingLimitField; }
      set { this.spendingLimitField = value; }
    }

    public string startDateTime {
      get { return this.startDateTimeField; }
      set { this.startDateTimeField = value; }
    }

    public string endDateTime {
      get { return this.endDateTimeField; }
      set { this.endDateTimeField = value; }
    }

    public BudgetOrderRequest lastRequest {
      get { return this.lastRequestField; }
      set { this.lastRequestField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class BudgetOrderRequest {
    private BudgetOrderRequestStatus statusField;

    private bool statusFieldSpecified;

    private string dateField;

    private string billingAccountNameField;

    private string poNumberField;

    private string budgetOrderNameField;

    private Money spendingLimitField;

    private string startDateTimeField;

    private string endDateTimeField;

    public BudgetOrderRequestStatus status {
      get { return this.statusField; }
      set {
        this.statusField = value;
        this.statusSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool statusSpecified {
      get { return this.statusFieldSpecified; }
      set { this.statusFieldSpecified = value; }
    }

    public string date {
      get { return this.dateField; }
      set { this.dateField = value; }
    }

    public string billingAccountName {
      get { return this.billingAccountNameField; }
      set { this.billingAccountNameField = value; }
    }

    public string poNumber {
      get { return this.poNumberField; }
      set { this.poNumberField = value; }
    }

    public string budgetOrderName {
      get { return this.budgetOrderNameField; }
      set { this.budgetOrderNameField = value; }
    }

    public Money spendingLimit {
      get { return this.spendingLimitField; }
      set { this.spendingLimitField = value; }
    }

    public string startDateTime {
      get { return this.startDateTimeField; }
      set { this.startDateTimeField = value; }
    }

    public string endDateTime {
      get { return this.endDateTimeField; }
      set { this.endDateTimeField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BudgetOrderRequest.Status", Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public enum BudgetOrderRequestStatus {
    UNDER_REVIEW,
    APPROVED,
    REJECTED,
    CANCELLED,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class BudgetOrderOperation : Operation {
    private BudgetOrder operandField;

    public BudgetOrder operand {
      get { return this.operandField; }
      set { this.operandField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class BillingAccount {
    private string idField;

    private string nameField;

    private string currencyCodeField;

    private string primaryBillingIdField;

    private string secondaryBillingIdField;

    public string id {
      get { return this.idField; }
      set { this.idField = value; }
    }

    public string name {
      get { return this.nameField; }
      set { this.nameField = value; }
    }

    public string currencyCode {
      get { return this.currencyCodeField; }
      set { this.currencyCodeField = value; }
    }

    public string primaryBillingId {
      get { return this.primaryBillingIdField; }
      set { this.primaryBillingIdField = value; }
    }

    public string secondaryBillingId {
      get { return this.secondaryBillingIdField; }
      set { this.secondaryBillingIdField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class BudgetOrderPage : Page {
    private BudgetOrder[] entriesField;

    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public BudgetOrder[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class CustomerOrderLineError : ApiError {
    private CustomerOrderLineErrorReason reasonField;

    private bool reasonFieldSpecified;

    public CustomerOrderLineErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "CustomerOrderLineError.Reason", Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public enum CustomerOrderLineErrorReason {
    INVALID_ORDER_LINE_ID,
    END_DATE_BEFORE_START_DATE,
    NEGATIVE_SPEND,
    CREATE_IN_PAST,
    ALREADY_STARTED,
    ALREADY_SPENT,
    FINISHED_IN_THE_PAST,
    CANCEL_ACTIVE,
    OVERLAP_DATE_RANGE,
    COS_CHANGE,
    NON_ADWORDS,
    START_DATE_AFTER_ACTUAL,
    END_DATE_PAST_MAX,
    PARENT_IS_SELF,
    CANNOT_CANCEL_NEW,
    CANNOT_CANCEL_STARTED,
    CANNOT_PROMOTE_NON_PENDING_ORDERLINE,
    UPDATE_ORDERLINE_WILL_SHIFT_CURRENT,
    ORDERLINE_BEING_MODIFIED_IS_NOT_NORMAL_OR_PENDING,
    INVALID_STATUS_CHANGE,
    MORE_THAN_ONE_OPERATION_NOT_PERMITTED,
    INVALID_TIMEZONE_IN_DATE_RANGES,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public partial class BudgetOrderError : ApiError {
    private BudgetOrderErrorReason reasonField;

    private bool reasonFieldSpecified;

    public BudgetOrderErrorReason reason {
      get { return this.reasonField; }
      set {
        this.reasonField = value;
        this.reasonSpecified = true;
      }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool reasonSpecified {
      get { return this.reasonFieldSpecified; }
      set { this.reasonFieldSpecified = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Xml.Serialization.XmlTypeAttribute(TypeName = "BudgetOrderError.Reason", Namespace = "https://adwords.google.com/api/adwords/billing/v201409")]
  public enum BudgetOrderErrorReason {
    BUDGET_APPROVAL_IN_PROGRESS,
    SERVICE_UNAVAILABLE,
    FIELD_NOT_ELIGIBLE_FOR_CURRENT_BILLING,
    INVALID_BILLING_ACCOUNT,
    GENERIC_BILLING_ERROR,
    INVALID_BILLING_ACCOUNT_ID_FORMAT,
    INVALID_BUDGET_DATE_RANGE,
    INCOMPATIBLE_CURRENCY,
    BUDGET_UPDATE_DENIED,
    BUDGET_ALREADY_STARTED,
    BUDGET_ALREADY_ENDED,
    INVALID_CONSTRAINT,
    INVALID_BID_TOO_LARGE,
    NO_SUCH_BUDGET_FOUND,
    INVALID_BUDGET_ALREADY_SPENT,
    INVALID_TIMEZONE_IN_DATE,
    ACCOUNT_BUDGET_ID_SET_IN_ADD,
    MORE_THAN_ONE_OPERATIONS,
    MCC_HIERARCHY_SIZE_TOO_LARGE,
    INVALID_MCC_HIERARCHY,
    UNKNOWN
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Web.Services.WebServiceBindingAttribute(Name = "BudgetServiceSoapBinding", Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListReturnValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Operation))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ComparableValue))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(Page))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationException))]
  public partial class BudgetService : AdWordsSoapClient, IBudgetService {
    private RequestHeader requestHeaderField;

    private ResponseHeader responseHeaderField;

    public BudgetService() {
      this.Url = "https://adwords.google.com/api/adwords/cm/v201409/BudgetService";
    }

    public virtual RequestHeader RequestHeader {
      get { return this.requestHeaderField; }
      set { this.requestHeaderField = value; }
    }

    public virtual ResponseHeader ResponseHeader {
      get { return this.responseHeaderField; }
      set { this.responseHeaderField = value; }
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BudgetPage get(Selector selector) {
      object[] results = this.Invoke("get", new object[] { selector });
      return ((BudgetPage) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BudgetReturnValue mutate([System.Xml.Serialization.XmlElementAttribute("operations")]
BudgetOperation[] operations) {
      object[] results = this.Invoke("mutate", new object[] { operations });
      return ((BudgetReturnValue) (results[0]));
    }

    [System.Web.Services.Protocols.SoapHeaderAttribute("ResponseHeader", Direction = System.Web.Services.Protocols.SoapHeaderDirection.Out)]
    [System.Web.Services.Protocols.SoapHeaderAttribute("RequestHeader")]
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace = "https://adwords.google.com/api/adwords/cm/v201409", ResponseNamespace = "https://adwords.google.com/api/adwords/cm/v201409", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("rval")]
    public virtual BudgetPage query([System.Xml.Serialization.XmlElementAttribute("query")]
string query1) {
      object[] results = this.Invoke("query", new object[] { query1 });
      return ((BudgetPage) (results[0]));
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BudgetReturnValue : ListReturnValue {
    private Budget[] valueField;

    private ApiError[] partialFailureErrorsField;

    [System.Xml.Serialization.XmlElementAttribute("value")]
    public Budget[] value {
      get { return this.valueField; }
      set { this.valueField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("partialFailureErrors")]
    public ApiError[] partialFailureErrors {
      get { return this.partialFailureErrorsField; }
      set { this.partialFailureErrorsField = value; }
    }
  }


  [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "https://adwords.google.com/api/adwords/cm/v201409")]
  public partial class BudgetPage : Page {
    private Budget[] entriesField;
    [System.Xml.Serialization.XmlElementAttribute("entries")]
    public Budget[] entries {
      get { return this.entriesField; }
      set { this.entriesField = value; }
    }
  }
  public interface ICampaignAdExtensionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    CampaignAdExtensionPage get(Selector serviceSelector);
    CampaignAdExtensionReturnValue mutate(CampaignAdExtensionOperation[] operations);
  }
  public interface ICampaignCriterionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    CampaignCriterionPage get(Selector serviceSelector);
    CampaignCriterionReturnValue mutate(CampaignCriterionOperation[] operations);
    CampaignCriterionPage query(string query1);
  }
  public interface ICampaignService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    CampaignPage get(Selector serviceSelector);
    CampaignReturnValue mutate(CampaignOperation[] operations);
    CampaignLabelReturnValue mutateLabel(CampaignLabelOperation[] operations);
    CampaignPage query(string query1);
  }
  public interface ICampaignFeedService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    CampaignFeedPage get(Selector selector);
    CampaignFeedReturnValue mutate(CampaignFeedOperation[] operations);
    CampaignFeedPage query(string query1);
  }
  public interface IConstantDataService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AgeRange[] getAgeRangeCriterion();
    Carrier[] getCarrierCriterion();
    Gender[] getGenderCriterion();
    Language[] getLanguageCriterion();
    MobileDevice[] getMobileDeviceCriterion();
    OperatingSystemVersion[] getOperatingSystemVersionCriterion();
    ProductBiddingCategoryData[] getProductBiddingCategoryData(Selector selector);
    CriterionUserInterest[] getUserInterestCriterion(ConstantDataServiceUserInterestTaxonomyType userInterestTaxonomyType);
    Vertical[] getVerticalCriterion();
  }
  public interface IConversionTrackerService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    ConversionTrackerPage get(Selector serviceSelector);
    ConversionTrackerReturnValue mutate(ConversionTrackerOperation[] operations);
  }
  public interface ICustomerService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    Customer get();
    Customer mutate(Customer customer);
  }
  public interface ICustomerSyncService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    CustomerChangeData get(CustomerSyncSelector selector);
  }
  public interface ICustomerFeedService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    CustomerFeedPage get(Selector selector);
    CustomerFeedReturnValue mutate(CustomerFeedOperation[] operations);
    CustomerFeedPage query(string query1);
  }
  public interface IDataService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AdGroupBidLandscapePage getAdGroupBidLandscape(Selector serviceSelector);
    CriterionBidLandscapePage getCriterionBidLandscape(Selector serviceSelector);
    DomainCategoryPage getDomainCategory(Selector serviceSelector);
    AdGroupBidLandscapePage queryAdGroupBidLandscape(string query);
    CriterionBidLandscapePage queryCriterionBidLandscape(string query);
    DomainCategoryPage queryDomainCategory(string query);
  }
  public interface IAdGroupAdService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AdGroupAdPage get(Selector serviceSelector);
    AdGroupAdReturnValue mutate(AdGroupAdOperation[] operations);
    AdGroupAdLabelReturnValue mutateLabel(AdGroupAdLabelOperation[] operations);
    AdGroupAdPage query(string query1);
    Ad[] upgradeUrl(AdUrlUpgrade[] operations);
  }
  public interface IExperimentService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    ExperimentPage get(Selector serviceSelector);
    ExperimentReturnValue mutate(ExperimentOperation[] operations);
  }
  public interface IFeedService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    FeedPage get(Selector selector);
    FeedReturnValue mutate(FeedOperation[] operations);
    FeedPage query(string query1);
  }
  public interface IFeedItemService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    FeedItemPage get(Selector selector);
    FeedItemReturnValue mutate(FeedItemOperation[] operations);
    FeedItemPage query(string query1);
  }
  public interface IFeedMappingService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    FeedMappingPage get(Selector selector);
    FeedMappingReturnValue mutate(FeedMappingOperation[] operations);
    FeedMappingPage query(string query1);
  }
  public interface IGeoLocationService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    GeoLocation[] get(GeoLocationSelector selector);
  }
  public interface ILocationCriterionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    LocationCriterion[] get(Selector selector);
    LocationCriterion[] query(string query1);
  }
  public interface IManagedCustomerService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    ManagedCustomerPage get(Selector serviceSelector);
    PendingInvitation[] getPendingInvitations(PendingInvitationSelector selector);
    ManagedCustomerReturnValue mutate(ManagedCustomerOperation[] operations);
    ManagedCustomerLink[] mutateLink(LinkOperation[] operations);
    ManagedCustomerLink[] mutateManager(MoveOperation[] operations);
  }
  public interface IMediaService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    MediaPage get(Selector serviceSelector);
    MediaPage query(string query1);
    Media[] upload(Media[] media);
  }
  public interface IMutateJobService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    Job[] get(JobSelector selector);
    JobResult getResult(JobSelector selector);
    SimpleMutateJob mutate(Operation[] operations, BulkMutateJobPolicy policy);
  }
  public interface IOfflineConversionFeedService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    OfflineConversionFeedReturnValue mutate(OfflineConversionFeedOperation[] operations);
  }
  public interface IAdGroupFeedService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AdGroupFeedPage get(Selector selector);
    AdGroupFeedReturnValue mutate(AdGroupFeedOperation[] operations);
    AdGroupFeedPage query(string query1);
  }
  public interface IReportDefinitionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    ReportDefinitionField[] getReportFields(ReportDefinitionReportType reportType);
  }
  public interface ITargetingIdeaService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    TargetingIdeaPage get(TargetingIdeaSelector selector);
  }
  public interface ITrafficEstimatorService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    TrafficEstimatorResult get(TrafficEstimatorSelector selector);
  }
  public interface IAdwordsUserListService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    UserListPage get(Selector serviceSelector);
    UserListReturnValue mutate(UserListOperation[] operations);
  }
  public interface IExpressBusinessService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    ExpressBusinessPage get(Selector selector);
    ExpressBusiness[] mutate(ExpressBusinessOperation[] operations);
  }
  public interface IBudgetSuggestionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    BudgetSuggestion get(BudgetSuggestionSelector selector);
  }
  public interface IProductService {
    string text {
      get;
      set;
    }
    string locale {
      get;
      set;
    }
  }
  public interface IPromotionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    PromotionPage get(Selector selector);
    Promotion[] mutate(PromotionOperation[] operations);
  }
  public interface IProductServiceService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    ProductServicePage get(Selector selector);
  }
  public interface ICampaignSharedSetService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    CampaignSharedSetPage get(Selector selector);
    CampaignSharedSetReturnValue mutate(CampaignSharedSetOperation[] operations);
  }
  public interface ISharedCriterionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    SharedCriterionPage get(Selector selector);
    SharedCriterionReturnValue mutate(SharedCriterionOperation[] operations);
  }
  public interface IAdGroupCriterionService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AdGroupCriterionPage get(Selector serviceSelector);
    AdGroupCriterionReturnValue mutate(AdGroupCriterionOperation[] operations);
    AdGroupCriterionLabelReturnValue mutateLabel(AdGroupCriterionLabelOperation[] operations);
    AdGroupCriterionPage query(string query1);
  }
  public interface ISharedSetService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    SharedSetPage get(Selector selector);
    SharedSetReturnValue mutate(SharedSetOperation[] operations);
  }
  public interface ILabelService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    LabelPage get(Selector serviceSelector);
    LabelReturnValue mutate(LabelOperation[] operations);
    LabelPage query(string query1);
  }
  public interface IAdGroupService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AdGroupPage get(Selector serviceSelector);
    AdGroupReturnValue mutate(AdGroupOperation[] operations);
    AdGroupLabelReturnValue mutateLabel(AdGroupLabelOperation[] operations);
    AdGroupPage query(string query1);
  }
  public interface IAdGroupBidModifierService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AdGroupBidModifierPage get(Selector selector);
    AdGroupBidModifierReturnValue mutate(AdGroupBidModifierOperation[] operations);
    AdGroupBidModifierPage query(string query1);
  }
  public interface IAdParamService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    AdParamPage get(Selector serviceSelector);
    AdParam[] mutate(AdParamOperation[] operations);
  }
  public interface IBiddingStrategyService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    BiddingStrategyPage get(Selector selector);
    BiddingStrategyReturnValue mutate(BiddingStrategyOperation[] operations);
    BiddingStrategyPage query(string query1);
  }
  public interface IBudgetOrderService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    BudgetOrderPage get(Selector serviceSelector);
    BillingAccount[] getBillingAccounts();
    BudgetOrderReturnValue mutate(BudgetOrderOperation[] operations);
  }
  public interface IBudgetService {
    RequestHeader RequestHeader {
      get;
      set;
    }
    ResponseHeader ResponseHeader {
      get;
      set;
    }
    BudgetPage get(Selector selector);
    BudgetReturnValue mutate(BudgetOperation[] operations);
    BudgetPage query(string query1);
  }
}
