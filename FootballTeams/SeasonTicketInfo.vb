Public Class SeasonTicketInfo
    'Setup local variables
    Private _sessionTicketNum As Integer
    Private _yearlyCharge As Double
    Private _teamName As String
    Private _startDate As Date
    Private _datePurchased As Date
    Private _customerTitle As String
    Private _customerForename As String
    Private _customerSurname As String
    Private _customerAddress As String
    Private _customerPostcode As String
    Private _customerTelNum As String
    Dim _total As Integer
    'This local variable will hold the value of the total of tickets 
    Private Shared _countTickets As Integer
    'Setup the properties for each of the local variables 
    Public Property SessionTicketNum As Integer
        Get
            Return _sessionTicketNum
        End Get
        Set(value As Integer)
            _sessionTicketNum = value
        End Set
    End Property

    Public Property YearlyCharge As Double
        Get
            Return _yearlyCharge
        End Get
        Set(value As Double)
            _yearlyCharge = value
        End Set
    End Property

    Public Property TeamName As String
        Get
            Return _teamName
        End Get
        Set(value As String)
            _teamName = value
        End Set
    End Property

    Public Property StartDate As Date
        Get
            Return _startDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Property DatePurchased As Date
        Get
            Return _datePurchased
        End Get
        Set(value As Date)
            _datePurchased = value
        End Set
    End Property

    Public Property CustomerTitle As String
        Get
            Return _customerTitle
        End Get
        Set(value As String)
            _customerTitle = value
        End Set
    End Property
    Public Property CustomerForename As String
        Get
            Return _customerForename
        End Get
        Set(value As String)
            _customerForename = value
        End Set
    End Property

    Public Property CustomerSurname As String
        Get
            Return _customerSurname
        End Get
        Set(value As String)
            _customerSurname = value
        End Set
    End Property

    Public Property CustomerAddress As String
        Get
            Return _customerAddress
        End Get
        Set(value As String)
            _customerAddress = value
        End Set
    End Property

    Public Property CustomerPostcode As String
        Get
            Return _customerPostcode
        End Get
        Set(value As String)
            _customerPostcode = value
        End Set
    End Property

    Public Property CustomerTelNum As String
        Get
            Return _customerTelNum
        End Get
        Set(value As String)
            _customerTelNum = value
        End Set
    End Property

    Public Shared ReadOnly Property CountTickets As Integer
        Get
            Return _countTickets
        End Get
    End Property
    'This is the first constructor 
    Sub New()
        _sessionTicketNum = 0
        _yearlyCharge = 0.0
        _teamName = ""
        _startDate = "00/00/0000"

    End Sub
    'This is the overloaded constructor 
    Sub New(SessionTicNumIn As Integer, YearlyChangeIn As Double, TeamNameIn As String, StartDateIn As Date, DatePurchasedIn As Date, CustomerTitleIn As String,
            CustomerForenameIn As String, CustomerSurnameIn As String, CustomerAddressIn As String, CustomerPostCodeIn As String, CustomerTelNumIn As String)
        _sessionTicketNum = SessionTicNumIn
        _yearlyCharge = YearlyChangeIn
        _teamName = TeamNameIn
        _startDate = StartDateIn
        _datePurchased = DatePurchasedIn
        _customerTitle = CustomerTitleIn
        _customerForename = CustomerForenameIn
        _customerSurname = CustomerSurnameIn
        _customerAddress = CustomerAddressIn
        _customerPostcode = CustomerPostCodeIn
        _customerTelNum = CustomerTelNumIn
        _countTickets += 1
    End Sub
    'This function will return the VAT
    Public Function USEVAT(num As Double)
        Return GETVAT(Me.YearlyCharge)

    End Function
    Public Shared Function GETVAT(vat As Double)
        Return vat / 10

    End Function


    'This function will return the season ticket charge, this is set to overridable, so that the function can be used in the derived classes.  
    Public Overridable Function GetSeasonTicketCharge()
        Return YearlyCharge + GETVAT(10)
    End Function
    'This is the destructor method
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    'This is the remove method which will call the destructor and take one away from the count 
    Public Sub Remove()
        _countTickets -= 1
        Me.Finalize()
    End Sub
End Class
