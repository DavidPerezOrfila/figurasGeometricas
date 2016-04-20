Public Class Punto
    'Se crean las cordenadas x e y como integer

    Private x, y As Integer

    'Creamos un método(constructor), indicamos que si no recibe valores, el valor inicial de x e y sería (0,0)

    Public Sub New()
        Me.x = 0
        Me.y = 0
    End Sub

    'Ahora creamos otro método que recibe valores y sustituye el valor inicial de x e y

    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        Me.x = x
        Me.y = y
    End Sub
    'Al ser declaradas las propiedades x e y como privadas debemos crear dos funciones publicas llamadas getter para que podamos acceder
    'desde el exterior
    Public Function getX() As Integer
        'los getters no necesitan argumentos
        Return Me.x
    End Function

    Public Function getY() As Integer
        Return Me.y
    End Function

    'Ahora creamos los setters como sub ya que no devuelven valor, nos pasan un argumento. 
    Public Sub setX(ByVal x As Integer)
        Me.x = x
    End Sub

    Public Sub setY(ByVal y As Integer)
        Me.y = y
    End Sub

    Public Overrides Function toString() As String
        'Overrides fuerza a VB a utilizar este método en lugar del toString por defecto
        'Return nos devuelve la cadena de texto que queremos que se muestre cuando pidamos que nos convierta el resultado a
        'una cadena de texto

        Return "Punto{x=" + Me.x.ToString + "," + "y=" + Me.y.ToString + "}"

    End Function

    Public Function distancia(ByVal p As Punto) As Double
        'Creamos el método dístancia restando el primer punto que ya tenemos (me) menos los getters del segundo punto

        Dim dX As Integer = Me.x - p.getX
        Dim dY As Integer = Me.y - p.getY

        Return Math.Sqrt((dX ^ 2) + (dY ^ 2))

    End Function

    Public Function suma(ByVal p As Punto) As Punto
        'sumamos los valores que ya disponemos más los valores que recibimos del segundo punto
        Return New Punto(Me.getX() + p.getX(), Me.getY + p.getY())

    End Function

    Public Function resta(ByVal p As Punto) As Punto
        'Restamos los valores que ya disponemos menos los valores que recibimos del segundo punto
        Return New Punto(Me.getX() - p.getX(), Me.getY - p.getY())
    End Function

    Public Function multiplicacion(ByVal p As Punto) As Punto
        Return New Punto(Me.getX() * p.getX(), Me.getY * p.getY())
    End Function
    Public Function esigual(point As Punto) As Boolean
        Dim igual As Boolean
        If Me.x = point.x And Me.y = point.y Then
            igual = True
        Else
            igual = False
        End If
        Return igual
    End Function

End Class
