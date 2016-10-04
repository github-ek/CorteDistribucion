Public Class DocumentoOrdenExcluida
    Private _ordenId As Integer?
    Private _clienteId As Integer
    Private _clienteCodigo As String
    Private _numeroDocumento As String
    Private _existe As Boolean
    Private _incluida As Boolean

    Public Sub New(ByVal clienteId As Integer, ByVal numeroDocumento As String, ByVal clienteCodigo As String, ordenId As Integer?, existe As Boolean, incluida As Boolean)
        Me.ClienteId = clienteId
        Me.NumeroDocumento = numeroDocumento
        Me.ClienteCodigo = clienteCodigo
        Me.OrdenId = ordenId
        Me._existe = existe
        Me._incluida = incluida
    End Sub

    Public Property OrdenId As Integer?
        Get
            Return _ordenId
        End Get
        Set(value As Integer?)
            _ordenId = value
        End Set
    End Property
    Public Property ClienteId As Integer
        Get
            Return _clienteId
        End Get
        Set(value As Integer)
            _clienteId = value
        End Set
    End Property

    Public Property ClienteCodigo As String
        Get
            Return _clienteCodigo
        End Get
        Set(value As String)
            _clienteCodigo = value
        End Set
    End Property
    Public Property NumeroDocumento As String
        Get
            Return _numeroDocumento
        End Get
        Set(value As String)
            _numeroDocumento = value
        End Set
    End Property
    Public ReadOnly Property Existe() As Boolean
        Get
            Return _existe
        End Get
    End Property

    Public ReadOnly Property Incluida() As Boolean
        Get
            Return _incluida
        End Get
    End Property

End Class
