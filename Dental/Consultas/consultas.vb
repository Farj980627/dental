Imports MySql.Data.MySqlClient
Public Class consultas
    Public Shared Function login(puser, ppass) As Boolean
        Dim con As MySqlConnection = conexion.conection
        Dim log As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT user, password FROM users WHERE user='{0}' AND password= '{1}'", puser, ppass), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            If reader.HasRows = True Then
                log = True
            End If
        End If
        con.Close()
        Return log
    End Function
    Public Shared Function getProductoByBarCode(pbarcode) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_product,name,price,model,color,barcode FROM products  WHERE barcode = '{0}'", pbarcode), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByProductosParaInv(pnombre) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE name LIKE '%{0}%'", pnombre), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByProduct(pid) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_product,name,price,model,color,barcode FROM products  WHERE id_product = '{0}'", pid), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function

    Public Shared Function getProductosAll() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products  "), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByDate(pdateInicio, pdateFinal) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE date >= '{0}' AND date <= '{1}'", pdateInicio, pdateFinal), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByCategoriaParaInv(pnombre) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE type LIKE '%{0}%'", pnombre), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductosByBarcodeParaInv(pbarcode) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE barcode LIKE '%{0}%'", pbarcode), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getReportsAll() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name,pr.type,pr.model,pr.color,pr.barcode, sl.quantity, sl.date,sl.hour, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product ORDER BY   id_sale"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getDayliReport(pdate) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name,pr.type,pr.model,pr.color,pr.barcode, sl.quantity, sl.date,sl.hour, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product AND sl.date='{0}' ", pdate), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getDateReport(pdate1, pdate2) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name,pr.type, pr.model,pr.color,pr.barcode, sl.quantity, sl.date,sl.hour, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product AND sl.date >='{0}' AND sl.date <='{1}' ", pdate1, pdate2), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getDateTypeReport(pdate1, pdate2, ptipo) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name,pr.type,pr.model,pr.color,pr.barcode, sl.quantity, sl.date,sl.hour, sl.type, sl.total FROM sales sl JOIN products pr WHERE  sl.id_product = pr.id_product AND sl.date >='{0}' AND sl.date <='{1}' AND sl.type= '{2}'", pdate1, pdate2, ptipo), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProductReport(pproduct) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT pr.name,pr.type, pr.model,pr.color,pr.barcode, sl.quantity, sl.date,sl.hour, sl.type, sl.total FROM sales sl JOIN products pr WHERE sl.id_product = pr.id_product AND pr.name like '{0}%'", pproduct), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getCantidadInventario(barcode) As String
        Dim con As MySqlConnection = conexion.conection
        Dim cant As String = 0
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT quantity FROM products WHERE barcode='{0}' ", barcode), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            cant = reader(0).ToString
        End If
        con.Close()
        Return cant
    End Function
    Public Shared Sub updInventario(cantidad, pname)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE products SET quantity='{0}' WHERE id_product='{1}'", cantidad, pname), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub insSale(pid_pro, pquantity, pdate, phour, ptipo, ptotal)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO sales(id_product,quantity,date,hour,type, total) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", pid_pro, pquantity, pdate, phour, ptipo, ptotal), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub delProductoType(type)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("DELETE FROM producttype WHERE type='{0}'", type), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Shared Sub delProducto(pid)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("DELETE FROM products WHERE id_product='{0}'", pid), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub insProducto(ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO products(type,name,brand,model,color,price,barcode,quantity,min,date) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Sub updInventarioAll(ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate, pid)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE products SET type='{0}', name='{1}', brand='{2}', model='{3}', color='{4}', price='{5}', barcode='{6}', quantity='{7}', min='{8}', date='{9}'  WHERE id_product='{10}'", ptype, pname, pbrand, pmodel, pcolor, pprice, pbarcode, pquantity, pmin, pdate, pid), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getProductosByID(pid) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE id_product='{0}'", pid), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProducType() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT type FROM producttype "), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Sub insProductTyper(type)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO producttype(type) VALUES('{0}')", type), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Class
