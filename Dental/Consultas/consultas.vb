Imports MySql.Data.MySqlClient
Public Class consultas
    Public Shared Function login(puser, ppass) As Boolean
        Dim con As MySqlConnection = conexion.conection
        Dim log As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT us.user, us.password, lvl.id_level FROM users us JOIN levels lvl WHERE us.id_level = lvl.id_level AND us.user = '{0}' AND us.password='{1}'", puser, ppass), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            If reader.HasRows = True Then
                log = True
                Principal.userLevel = reader(2).ToString
                Principal.username = reader(0).ToString
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
    Public Shared Sub insUser(puser, ppass, plevel)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO users(user,password,id_level) VALUES('{0}','{1}','{2}')", puser, ppass, plevel), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getUsuarios() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM users"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Sub updUser(pid, puser, ppass, plevel)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("UPDATE users SET user= '{0}', password='{1}', id_level='{2}' where id_user = '{3}'", puser, ppass, plevel, pid), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function getUsuarios2(pusuario) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_user,user,password FROM users where user='{0}'", pusuario), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getLevel() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT id_level, identifier FROM levels"), con)
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
    Public Shared Function getCantidadInventarioBYID(pid) As String
        Dim con As MySqlConnection = conexion.conection
        Dim cant As String = 0
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT quantity FROM products WHERE id_product='{0}' ", pid), con)
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

    'Consultas para favoritos
    Public Shared Function getFavorites() As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM favorites ORDER BY id_favorito DESC LIMIT 1 "), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getProdutToFav(idpro) As String
        Dim con As MySqlConnection = conexion.conection
        Dim cant As String = ""
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name, brand FROM products WHERE id_product='{0}' ", idpro), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            cant = reader(0).ToString & "," & reader(1).ToString
        End If
        con.Close()
        Return cant
    End Function

    Public Shared Sub insFav(pid1, pid2, pid3, pid4, pid5, pid6, pid7, pid8, pid9, pid10, pid11, pid12, pid13, pid14, pid15)
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO favorites(id_1,id_2,id_3,id_4,id_5,id_6,id_7,id_8,id_9,id_10,id_11,id_12,id_13,id_14,id_15) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')", pid1, pid2, pid3, pid4, pid5, pid6, pid7, pid8, pid9, pid10, pid11, pid12, pid13, pid14, pid15), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    'Consultas para botones favoritos 
    Public Shared Function viewDI1(ByVal pid1 As String) As String
        Dim con As MySqlConnection = conexion.conection
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT name, brand FROM products WHERE id_product='{0}' ", pid1), con)
        Dim one As String = ""
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            one = reader(0).ToString & "," & reader(1).ToString
        End If
        Return one

    End Function
    Public Shared Function getSix(id) As Boolean
        Dim con As MySqlConnection = conexion.conection
        Dim log As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE name LIKE 'Six%' and id_product= '{0}'", id), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            If reader.HasRows = True Then
                log = True
            End If
        End If
        con.Close()
        Return log
    End Function

    Public Shared Function notgetSix(brcd) As Boolean
        Dim con As MySqlConnection = conexion.conection
        Dim log As Boolean = False
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE name NOT LIKE 'Six%' and barcode= '{0}'", brcd), con)
        Dim reader As MySqlDataReader = cmd.ExecuteReader
        If reader.Read Then
            If reader.HasRows = True Then
                log = True
            End If
        End If
        con.Close()
        Return log
    End Function
    Public Shared Function notgetSixDT(brcd) As DataTable
        Dim con As MySqlConnection = conexion.conection
        Dim dt As New DataTable
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM products WHERE name NOT LIKE 'Six%' and barcode= '{0}' ", brcd), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function

End Class
