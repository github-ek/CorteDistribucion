Imports System.Data.SqlClient
Imports System.Text

Module DB

    Public Function GetSQLActualizarIncluidasExcluidas(list As List(Of DocumentoOrdenIncluida)) As String
        Dim sql As String =
        " WITH " & vbLf &
        " cte_00 AS " & vbLf &
        " ( " & vbLf &
        "     SELECT " & vbLf &
        "         a.* " & vbLf &
        "     FROM " & vbLf &
        "     ( " & vbLf &
        "         VALUES " & vbLf &
        "             @list" & vbLf &
        "             (null,null) " & vbLf &
        "     ) a(id_cliente,numero_orden)  " & vbLf &
        " ) " & vbLf &
        " SELECT " & vbLf &
        "     a.id_cliente,b.codigo,a.numero_orden,COALESCE(c.id_orden,0) AS id_orden, CAST(CASE WHEN c.id_orden IS NOT NULL THEN 1 ELSE 0 END AS BIT) AS existe " & vbLf &
        " FROM cte_00 a " & vbLf &
        " INNER JOIN crm.clientes b ON " & vbLf &
        "     b.id_cliente = a.id_cliente " & vbLf &
        " LEFT OUTER JOIN  ordenes.ordenes c ON " & vbLf &
        "     c.id_cliente = a.id_cliente " & vbLf &
        " AND c.numero_orden = a.numero_orden " & vbLf &
        " ORDER BY " & vbLf &
        "     b.codigo,existe DESC,a.numero_orden"

        Dim sb As New StringBuilder()

        For Each e In list
            sb.Append("(").Append(e.ClienteId).Append(",'").Append(e.NumeroDocumento).Append("'),").Append(vbLf)
        Next

        Return sql.Replace("@list", sb.ToString())
    End Function

    Public Sub SQL_tms_AsignarCitaEntrega(ordenId As Integer, fechaCitaEntrega As DateTime, hoMi As TimeSpan, hoMa As TimeSpan, usuario As String, cmd As SqlCommand)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@ordenId", ordenId)
        cmd.Parameters.AddWithValue("@fechaCita", fechaCitaEntrega)
        cmd.Parameters.AddWithValue("@hoMi", hoMi)
        cmd.Parameters.AddWithValue("@hoMa", hoMa)
        cmd.Parameters.AddWithValue("@usuario", usuario)

        cmd.ExecuteNonQuery()
    End Sub

    Public Sub SQL_tms_PlanillarRuta(rutaId As Integer, usuario As String, cmd As SqlCommand)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@rutaId", rutaId)
        cmd.Parameters.AddWithValue("@usuario", usuario)

        cmd.ExecuteNonQuery()
    End Sub

    Public Function SQL_tms_OrdenCerrar(IdOrden As Integer, NuevoEstado As String, connection As SqlConnection, transaction As SqlTransaction)
        Dim sql As String = "tms.OrdenCerrar"

        Using cmd = New SqlCommand(sql, connection, transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdOrden", IdOrden)
            cmd.Parameters.AddWithValue("@NuevoEstado", NuevoEstado)
            cmd.Parameters.AddWithValue("@Usuario", Environment.UserName)

            Dim p As SqlParameter = cmd.Parameters.Add("@Result", SqlDbType.Int)
            p.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            SQL_tms_OrdenCerrar = p.Value
        End Using
    End Function




    Public Function SQL_tms_OrdenReprogramar(IdOrden As Integer, FechaCita As DateTime, HoraMinCita As Integer, HoraMaxCita As Integer _
            , Notas As String, Usuario As String, CausalReprogramacion As Integer, connection As SqlConnection, transaction As SqlTransaction) As Integer
        Dim sql As String = "tms.OrdenReprogramar"

        Using cmd = New SqlCommand(sql, connection, transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdOrden", IdOrden)
            cmd.Parameters.AddWithValue("@FechaCita", FechaCita)
            cmd.Parameters.AddWithValue("@HoraMinCita", HoraMinCita)
            cmd.Parameters.AddWithValue("@HoraMaxCita", HoraMaxCita)
            cmd.Parameters.AddWithValue("@Notas", Notas)
            cmd.Parameters.AddWithValue("@Usuario", Usuario)
            cmd.Parameters.AddWithValue("@CausalReprogramacion", CausalReprogramacion)

            Dim p As SqlParameter = cmd.Parameters.Add("@Result", SqlDbType.Int)
            p.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()
            SQL_tms_OrdenReprogramar = p.Value
        End Using
    End Function



    Public Sub SQL_tms_RutaActualizarCajas(IdOrden As Integer, NumeroCajas As Integer, connection As SqlConnection, transaction As SqlTransaction)
        Dim sql As String = "tms.RutaActualizarCajas"

        Using cmd = New SqlCommand(sql, connection, transaction)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IdOrden", IdOrden)
            cmd.Parameters.AddWithValue("@NumeroCajas", NumeroCajas)

            Dim p As SqlParameter = cmd.Parameters.Add("@Result", SqlDbType.Int)
            p.Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            ' MsgBox(p.Value)
        End Using
    End Sub
End Module
