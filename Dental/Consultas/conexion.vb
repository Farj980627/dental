﻿Imports MySql.Data.MySqlClient
Public Class conexion

    Public Shared Function conection() As MySqlConnection
        Dim db As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()

        db.Server = "localhost"


        db.UserID = "root"
        db.Password = "rootroot"
        db.Database = "deposito"

        db.SslMode = MySqlSslMode.None
        Dim con As MySqlConnection = New MySqlConnection(db.ToString())
        con.Open()
        Return con
    End Function
End Class
