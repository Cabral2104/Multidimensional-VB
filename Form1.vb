Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btMostrar.Click
        ' Declarar y asignar valores al arreglo multidimensional
        Dim ventas(,) As Integer = {{100, 200, 300}, {400, 500, 600}, {700, 800, 900}}

        ' Crear una tabla para mostrar en el DataGridView
        Dim tabla As New DataTable()

        ' Agregar columnas a la tabla
        tabla.Columns.Add("Producto")
        tabla.Columns.Add("Mes 1")
        tabla.Columns.Add("Mes 2")
        tabla.Columns.Add("Mes 3")

        ' Agregar filas a la tabla con los datos del arreglo
        tabla.Rows.Add("Producto 1", ventas(0, 0), ventas(0, 1), ventas(0, 2))
        tabla.Rows.Add("Producto 2", ventas(1, 0), ventas(1, 1), ventas(1, 2))
        tabla.Rows.Add("Producto 3", ventas(2, 0), ventas(2, 1), ventas(2, 2))

        ' Mostrar la tabla en el DataGridView
        DataGridView1.DataSource = tabla
    End Sub
End Class
