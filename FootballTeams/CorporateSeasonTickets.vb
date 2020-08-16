Public Class CorporateSeasonTickets
    Inherits SeasonTicketInfo
    'Setup local variables
    Private _companyName As String
    Private _discountPercentage As Decimal
    Private _vipAccessRequired As String
    Private _vipCost As Double
    Private _companyContactName As String

    'Setup properties for each of the local variables 
    Public Property CompanyName As String
        Get
            Return _companyName
        End Get
        Set(value As String)
            _companyName = value
        End Set
    End Property

    Public Property DiscountPercentage As Decimal
        Get
            Return _discountPercentage
        End Get
        Set(value As Decimal)
            _discountPercentage = value
        End Set
    End Property

    Public Property VIPAccessRequired As String
        Get
            Return _vipAccessRequired
        End Get
        Set(value As String)
            _vipAccessRequired = value
        End Set
    End Property

    Public Property VIPCost As Double
        Get
            Return _vipCost
        End Get
        Set(value As Double)
            _vipCost = value
        End Set
    End Property

    Public Property CompanyContactName As String
        Get
            Return _companyContactName
        End Get
        Set(value As String)
            _companyContactName = value
        End Set
    End Property
    'This is the constructor for the corporate season ticket
    Sub New(SessionTicNumIn As Integer, YearlyChangeIn As Double, TeamNameIn As String, StartDateIn As Date, DatePurchasedIn As Date, CustomerTitleIn As String,
            CustomerForenameIn As String, CustomerSurnameIn As String, CustomerAddressIn As String, CustomerPostCodeIn As String, CustomerTelNumIn As String)

        MyBase.New(SessionTicNumIn, YearlyChangeIn, TeamNameIn, StartDateIn, DatePurchasedIn, CustomerTitleIn, CustomerForenameIn, CustomerSurnameIn, CustomerAddressIn, CustomerPostCodeIn, CustomerTelNumIn)
    End Sub

    'This is the overloaded constructor
    Sub New(SessionTicNumIn As Integer, YearlyChangeIn As Double, TeamNameIn As String, StartDateIn As Date, DatePurchasedIn As Date, CustomerTitleIn As String,
            CustomerForenameIn As String, CustomerSurnameIn As String, CustomerAddressIn As String, CustomerPostCodeIn As String, CustomerTelNumIn As String, CompanyNameIn As String, DiscountPercentageIn As Decimal,
            VIPAccessRequiredIn As String, VIPCostIn As Double, CompanyContactNameIn As String)

        MyBase.New(SessionTicNumIn, YearlyChangeIn, TeamNameIn, StartDateIn, DatePurchasedIn, CustomerTitleIn, CustomerForenameIn, CustomerSurnameIn, CustomerAddressIn, CustomerPostCodeIn, CustomerTelNumIn)
        _companyName = CompanyName
        _discountPercentage = DiscountPercentage
        _vipAccessRequired = VIPAccessRequired
        _vipCost = VIPCost
        _companyContactName = CompanyContactName
    End Sub

    'This function will return the full business address 
    Public Function GetBusinessFullAddress() As String
        Return Me.CompanyContactName & vbNewLine & MyBase.CustomerAddress & vbNewLine & MyBase.CustomerPostcode
    End Function
    'This function will return the season ticket charge for the corporate season tickets 
    Public Overrides Function GetSeasonTicketCharge()
        Return MyBase.YearlyCharge - (MyBase.YearlyCharge * (Me.DiscountPercentage / 100)) + Me.VIPCost
    End Function

End Class
