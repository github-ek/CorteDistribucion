Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text

Module Listas
    Public Sub FillCiudades(usuario As String, control As ComboBox)
        Dim sql = "tms.ListarCiudadesConBodegas"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@usuario", usuario)

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)
                With control
                    .ValueMember = "id_ciudad"
                    .DisplayMember = "nombre_alterno"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count) Then
                        If (My.Settings.CiudadOrigenId <> 0) Then
                            .SelectedValue = My.Settings.CiudadOrigenId
                            If (Not .SelectedValue Is Nothing) Then
                                Exit Sub
                            End If
                        End If
                        .SelectedIndex = 0
                    End If
                End With
            End Using
        End Using
    End Sub
    Public Sub FillTiposCortePlanificacionRuta(control As ComboBox)
        Dim sql = "tms.ListarTiposDeCorteDeRutas"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)
                With control
                    .ValueMember = "id_tipo_corte_ruta"
                    .DisplayMember = "nombre"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count) Then
                        If (My.Settings.TipoCorteRutaId <> 0) Then
                            .SelectedValue = My.Settings.TipoCorteRutaId
                            If (Not .SelectedValue Is Nothing) Then
                                Exit Sub
                            End If
                        End If
                        .SelectedIndex = 0
                    End If
                End With
            End Using
        End Using
    End Sub
    Public Sub FillCeDis(ciudadId As Integer, control As ListBox)
        Dim sql = "tms.ListarBodegasPorCiudad"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ciudadId", ciudadId)

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                With control
                    .ValueMember = "id_bodega"
                    .DisplayMember = "nombre_largo"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count > 0) Then
                        .SetSelected(0, False)
                    End If
                End With
            End Using
        End Using
    End Sub
    Public Sub FillClientes(control As ListBox)
        Dim sql = "tms.ListarClientes"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                With control
                    .ValueMember = "id_cliente"
                    .DisplayMember = "nombre"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count > 0) Then
                        .SetSelected(0, False)
                    End If
                End With
            End Using
        End Using
    End Sub
    Public Sub FillClientes(control As ComboBox)
        Dim sql = "tms.ListarClientes"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                With control
                    .ValueMember = "id_cliente"
                    .DisplayMember = "codigo"
                    .DataSource = ds.Tables(0)
                End With
            End Using
        End Using
    End Sub
    Public Sub FillServicios(clientes As ListBox, control As ListBox)
        Dim sql As String = GetSQLFillServicios(clientes)

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                With control
                    .ValueMember = "id_tipo_servicio"
                    .DisplayMember = "nombre"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count > 0) Then
                        .SetSelected(0, False)
                    End If
                End With
            End Using
        End Using
    End Sub
    Private Function GetSQLFillServicios(clientes As ListBox) As String
        Dim sql As String =
        "" &
        " WITH " &
        " cte_00 AS " &
        " ( " &
        " 	SELECT " &
        " 		* " &
        " 	FROM " &
        " 	( " &
        " 		VALUES " &
        " 			@list " &
        " 			(NULL) " &
        " 	)a(id_cliente) " &
        " 	WHERE " &
        " 	    a.id_cliente IS NOT NULL " &
        " ) " &
        " SELECT DISTINCT " &
        " 	b.id_tipo_servicio, " &
        " 	b.nombre, " &
        " 	b.ordinal " &
        " FROM cte_00 a " &
        " CROSS APPLY tms.ListarServiciosPorCliente(a.id_cliente) b " &
        " ORDER BY " &
        " 	b.ordinal "

        Dim sb As New StringBuilder()
        With clientes
            For Each drv As DataRowView In .SelectedItems
                sb.Append("(").Append(CStr(drv.Row("id_cliente"))).Append("),").Append(vbLf)
            Next
        End With

        sql = sql.Replace("@list", sb.ToString())

        Return sql
    End Function
    Public Sub FillCanales(control As ListBox)
        Dim sql = "tms.ListarCanales"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                With control
                    .ValueMember = "id_canal"
                    .DisplayMember = "nombre"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count > 0) Then
                        .SetSelected(0, False)
                    End If
                End With
            End Using
        End Using
    End Sub
    Public Sub FillCiudades(control As ListBox)
        Dim sql = "tms.ListarCiudades"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                With control
                    .ValueMember = "id_ciudad"
                    .DisplayMember = "nombre_alterno"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count > 0) Then
                        .SetSelected(0, False)
                    End If
                End With
            End Using
        End Using
    End Sub
    Public Sub FillDepartamentos(control As ListBox)
        Dim sql = "tms.ListarDepartamentos"

        Using con As New SqlConnection(My.Settings.SateliteConnectionString)
            Using cmd As New SqlCommand(sql, con)
                cmd.CommandType = CommandType.StoredProcedure

                Dim ds = New DataSet()
                Dim da = New SqlDataAdapter(cmd)

                da.Fill(ds)

                With control
                    .ValueMember = "id_departamento"
                    .DisplayMember = "nombre"
                    .DataSource = ds.Tables(0)

                    If (.Items.Count > 0) Then
                        .SetSelected(0, False)
                    End If
                End With
            End Using
        End Using
    End Sub

#Region "Asignación de Horas"
    Public Function GetHoras() As List(Of TimeSpan)
        Dim sql = "app.ListarHoras"
        Dim lista As List(Of TimeSpan) = New List(Of TimeSpan)

        Using connection As New SqlConnection(My.Settings.SateliteConnectionString)
            connection.Open()
            Using cmd As New SqlCommand(sql, connection)
                cmd.CommandType = CommandType.StoredProcedure
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While (reader.Read())
                        lista.Add(reader.GetTimeSpan(0))
                    End While
                End Using
            End Using
        End Using

        Return lista
    End Function
    Public Sub FillHoras(control As ComboBox, list As List(Of TimeSpan), AMPM As String)
        Dim homi As TimeSpan
        Dim homa As TimeSpan
        Select Case AMPM
            Case "AM"
                homi = New TimeSpan(0, 0, 0)
                homa = New TimeSpan(12, 0, 0)
            Case "PM"
                homi = New TimeSpan(12, 0, 1)
                homa = New TimeSpan(23, 59, 59)
            Case Else
                homi = New TimeSpan(0, 0, 0)
                homa = New TimeSpan(23, 59, 59)
        End Select
        Dim horasFiltradas = list.Where(Function(a) a.CompareTo(homi) >= 0 And a.CompareTo(homa) <= 0).ToList()
        FillHoras(control, horasFiltradas)
    End Sub

    Public Sub FillHoras(control As ComboBox, list As List(Of TimeSpan))
        Dim d As Date = Date.Today()
        With control
            .DisplayMember = "Text"
            .ValueMember = "Value"
            Dim l = list.OrderByDescending(Function(a) a).Select(Function(a) New With {Key .Value = a, .Text = d.Add(a).ToString("hh:mm tt", CultureInfo.InvariantCulture)}).ToList()
            .DataSource = l

            If (.Items.Count) Then
                .SelectedIndex = 0
            End If
        End With
    End Sub
#End Region

#Region "Cierre de ordenes"

    Public Function GetEstadosOrdenCierreOrden() As List(Of KeyValueObject(Of String, String))
        Dim sql = "tms.ListarEstadosOrdenParaCierreDeOrden"

        Return GetList(Of KeyValueObject(Of String, String)) _
                (My.Settings.SateliteConnectionString, sql,
                Function(reader)
                    Return New KeyValueObject(Of String, String) With
                {
                    .Key = reader("id_estado_orden"),
                    .Value = reader("nombre")
                }
                End Function)
    End Function

    Public Function GetCausalesDeNoEntrega() As List(Of CausalDeNovedadDeDistribucion)
        Dim sql = "tms.ListarCausalesDeNoEntregaParaCierreDeOrden"

        Return GetList(Of CausalDeNovedadDeDistribucion) _
                (My.Settings.SateliteConnectionString, sql,
                Function(reader)
                    Return New CausalDeNovedadDeDistribucion With
                {
                    .Id = reader("id_causal_novedad_distribucion"),
                    .Nombre = reader("nombre"),
                    .Descripcion = reader("descripcion"),
                    .IndicadorOtifId = reader("id_indicador_otif"),
                    .ResponsableId = IIf(IsDBNull(reader("id_responsable_novedad")), Nothing, reader("id_responsable_novedad")),
                    .ResponsableInternoId = IIf(IsDBNull(reader("id_responsable_interno_novedad")), Nothing, reader("id_responsable_interno_novedad")),
                    .TipoNovedadDeDistribucionId = Nothing
                }
                End Function)
    End Function

    Public Function GetCausalesDeNovedades() As List(Of CausalDeNovedadDeDistribucion)
        Dim sql = "tms.ListarCausalesDeNovedadesParaCierreDeOrden"

        Return GetList(Of CausalDeNovedadDeDistribucion) _
                (My.Settings.SateliteConnectionString, sql,
                Function(reader)
                    Return New CausalDeNovedadDeDistribucion With
                {
                    .Id = reader("id_causal_novedad_distribucion"),
                    .Nombre = reader("nombre"),
                    .Descripcion = reader("descripcion"),
                    .IndicadorOtifId = reader("id_indicador_otif"),
                    .ResponsableId = IIf(IsDBNull(reader("id_responsable_novedad")), Nothing, reader("id_responsable_novedad")),
                    .ResponsableInternoId = IIf(IsDBNull(reader("id_responsable_interno_novedad")), Nothing, reader("id_responsable_interno_novedad")),
                    .TipoNovedadDeDistribucionId = reader("id_tipo_novedad_distribucion")
                }
                End Function)
    End Function

    Public Function GetResponsablesDeNovedades() As List(Of KeyValueObject(Of Integer, String))
        Dim sql = "tms.ListarResponsablesDeNovedadParaCierreDeOrden"

        Return GetList(Of KeyValueObject(Of Integer, String)) _
                (My.Settings.SateliteConnectionString, sql,
                Function(reader)
                    Return New KeyValueObject(Of Integer, String) With
                {
                    .Key = reader("id_responsable_novedad"),
                    .Value = reader("nombre")
                }
                End Function)
    End Function

    Public Function GetResponsablesInternosDeNovedades() As List(Of KeyValueObject(Of Integer?, String))
        Dim sql = "tms.ListarResponsablesInternosDeNovedadParaCierreDeOrden"

        Dim list = New List(Of KeyValueObject(Of Integer?, String))

        list.Add(New KeyValueObject(Of Integer?, String) With
                 {
                 .Key = Nothing,
                 .Value = ""
                 })

        list.AddRange(GetList(Of KeyValueObject(Of Integer?, String)) _
                (My.Settings.SateliteConnectionString, sql,
                Function(reader)
                    Return New KeyValueObject(Of Integer?, String) With
                {
                    .Key = reader("id_responsable_interno_novedad"),
                    .Value = reader("nombre")
                }
                End Function))
        Return list
    End Function

    Public Function GetTiposDeNovedad() As List(Of TipoDeNovedadDeDistribucion)
        Dim sql = "tms.[ListarTiposDeNovedadesParaCierreDeOrden]"

        Return GetList(Of TipoDeNovedadDeDistribucion) _
                (My.Settings.SateliteConnectionString, sql,
                Function(reader)
                    Return New TipoDeNovedadDeDistribucion With
                {
                    .Id = reader("id_tipo_novedad_distribucion"),
                    .Nombre = reader("nombre"),
                    .Descripcion = reader("descripcion"),
                    .GrupoId = reader("id_grupo_novedad_distribucion"),
                    .GrupoNombre = reader("grupo_novedad_distribucion_nombre")
                }
                End Function)
    End Function

#End Region

#Region "Utilidades"
    Public Function GetSQLVALUESInt(values As ListBox.SelectedObjectCollection, key As String) As String
        Dim builder As New StringBuilder
        For Each Row In values
            builder.Append("(").Append(Row(key)).Append("),").AppendLine()
        Next
        Return builder.ToString()
    End Function

    Private Function GetList(Of T)(connectionString As String, sql As String, constructor As System.Func(Of SqlDataReader, T)) As List(Of T)
        Dim list As List(Of T) = New List(Of T)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using cmd As New SqlCommand(sql, connection)
                cmd.CommandType = CommandType.StoredProcedure
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While (reader.Read())
                        list.Add(constructor(reader))
                    End While
                End Using
            End Using
        End Using

        Return list
    End Function
    Public Sub FillComboBoxWithList(Of T)(control As ComboBox, list As List(Of T), displayMember As String)
        With control
            .DisplayMember = displayMember
            .Items.Clear()

            For Each e In list
                .Items.Add(e)
            Next
            .SelectedIndex = -1
        End With
    End Sub
#End Region


End Module
