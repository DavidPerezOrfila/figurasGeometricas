Public Class Cuadrado
    Private origen As Punto
    Private lado As Double

    Public Sub New()
        Me.origen = New Punto
        Me.lado = 0
    End Sub
    Public Sub New(ByVal lado As Double, ByVal origen As Punto)
        Me.origen = origen
        Me.lado = lado
    End Sub

    Public Function getLado() As Double
        Return Me.lado
    End Function

    Public Function getOrigen() As Punto
        Return Me.origen
    End Function

    Public Sub setLado(ByVal lado As Double)
        Me.lado = lado
    End Sub

    Public Sub setOrigen(ByVal origen As Punto)
        Me.origen = origen
    End Sub
    Public Function area() As Double
        Return lado ^ 2
    End Function
    Public Overrides Function toString() As String
        Return "cuadrado{4 lados= " + Me.lado.ToString + "," + "origen= " + Me.origen.toString + "}"
    End Function
    Public Function esigual(ByVal square As Cuadrado) As Boolean
        Dim equal As Boolean
        If Me.lado = square.lado And Me.origen Is square.origen Then
            equal = True
        Else
            equal = False
        End If
        Return equal
    End Function

End Class
