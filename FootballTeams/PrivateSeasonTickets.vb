Public Class PrivateSeasonTickets
    Inherits SeasonTicketInfo
    'Setup the local variables 
    Private _discountPercentage As Decimal
    Private _employerNumber As Integer
    Private _paymentMethod As String
    'Setup the properties for each of the local variables 
    Public Property DiscountPercentage As Decimal
        Get
            Return _discountPercentage
        End Get
        Set(value As Decimal)
            _discountPercentage = value
        End Set
    End Property

    Public Property EmployerNumber As Integer
        Get
            Return _employerNumber
        End Get
        Set(value As Integer)
            _employerNumber = value
        End Set
    End Property
    Public Property PaymentMethod As String
        Get
            Return _paymentMethod
        End Get
        Set(value As String)
            _paymentMethod = value
        End Set
    End Property
    'This is the constructor for the private season ticket
    Sub New(SessionTicNumIn As Integer, YearlyChangeIn As Double, TeamNameIn As String, StartDateIn As Date, DatePurchasedIn As Date, CustomerTitleIn As String,
            CustomerForenameIn As String, CustomerSurnameIn As String, CustomerAddressIn As String, CustomerPostCodeIn As String, CustomerTelNumIn As String)

        MyBase.New(SessionTicNumIn, YearlyChangeIn, TeamNameIn, StartDateIn, DatePurchasedIn, CustomerTitleIn, CustomerForenameIn, CustomerSurnameIn, CustomerAddressIn, CustomerPostCodeIn, CustomerTelNumIn)
    End Sub

    'This is the overloaded constructor for the private season ticket. 
    Sub New(SessionTicNumIn As Integer, YearlyChangeIn As Double, TeamNameIn As String, StartDateIn As Date, DatePurchasedIn As Date, CustomerTitleIn As String,
            CustomerForenameIn As String, CustomerSurnameIn As String, CustomerAddressIn As String, CustomerPostCodeIn As String, CustomerTelNumIn As String, DiscountPercentageIn As Decimal, EmployerNumberIn As Integer, PaymentMethodIn As String)

        MyBase.New(SessionTicNumIn, YearlyChangeIn, TeamNameIn, StartDateIn, DatePurchasedIn, CustomerTitleIn, CustomerForenameIn, CustomerSurnameIn, CustomerAddressIn, CustomerPostCodeIn, CustomerTelNumIn)

        _discountPercentage = DiscountPercentage
        _employerNumber = EmployerNumber
        _paymentMethod = PaymentMethod

    End Sub
    'This function will return the full address
    Public Function GetFullAddress() As String
        Return MyBase.CustomerTitle & " " & MyBase.CustomerForename & " " & MyBase.CustomerSurname & vbNewLine & MyBase.CustomerAddress & vbNewLine & MyBase.CustomerPostcode
    End Function
    'This function is overriding the getseasonticketcharge function from the base class, this will return the season ticket charge. 
    Public Overrides Function GetSeasonTicketCharge()
        Return MyBase.YearlyCharge - (MyBase.YearlyCharge * (Me.DiscountPercentage / 100)) + MyBase.USEVAT(10)
    End Function

End Class
