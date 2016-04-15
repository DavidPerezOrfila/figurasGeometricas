Public Class Circulo
    Private radio As Double
    Private origen As Punto

    Public Sub New()
        Me.radio = 0
        Me.origen = New Punto
    End Sub

    Public Sub New(ByVal radio As Double, origen As Punto)
        Me.radio = radio
        Me.origen = origen

    End Sub

    Public Function getRadio() As Double
        Return Me.radio
    End Function

    Public Function getOrigen() As Punto
        Return Me.origen
    End Function

    Public Sub setRadio(ByVal radio As Double)
        Me.radio = radio
    End Sub

    Public Sub setOrigen(ByVal origen As Punto)
        Me.origen = New Punto
    End Sub

    Public Function area() As Double
        Return radio ^ 2 * Math.PI
    End Function

    Public Function diametro() As Double
        Return Me.radio * 2
    End Function
    Public Function perimetro() As Double
        Return Math.PI * Me.diametro
    End Function

    Public Overrides Function toString() As String
        Return "Circulo{radio= " + Me.radio.ToString + " ," + "origen= " + Me.origen.toString + "}"
    End Function



End Class
