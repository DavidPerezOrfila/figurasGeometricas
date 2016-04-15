Public Class Form1
    'se crea un botón y creamos dos puntos, uno sin darle valores y el otro dándole valores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p1 As Punto
        p1 = New Punto

        Dim p2 As Punto
        p2 = New Punto(3, 4)

        MessageBox.Show(p1.getX())
        MessageBox.Show(p2.getY())

        p1.setX(5)
        p2.setY(3)

        MessageBox.Show(p1.toString + " ," + p2.toString)

        MessageBox.Show(p1.distancia(p2))

        MessageBox.Show(p1.suma(p2).toString)

        MessageBox.Show(p1.resta(p2).toString)

    End Sub


End Class
