Imports System.Data
Imports MySql.Data.MySqlClient

Public Class DbHelper
    Private connectionString As String = "Server=localhost;Database=system_login;User ID=root;Password=admin;"
    Private connection As MySqlConnection

    ' Método para abrir a conexão com o banco de dados
    Private Sub OpenConnection()
        If connection Is Nothing Then
            connection = New MySqlConnection(connectionString)
        End If

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    ' Método para fechar a conexão com o banco de dados
    Private Sub CloseConnection()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    ' Método para executar comandos SQL e retornar um DataSet
    Public Function ExecuteQuery(query As String) As DataSet
        OpenConnection()

        Dim dataAdapter As New MySqlDataAdapter(query, connection)
        Dim dataSet As New DataSet()
        dataAdapter.Fill(dataSet)

        CloseConnection()

        Return dataSet
    End Function

    ' Método para executar comandos como INSERT, UPDATE, DELETE
    Public Function ExecuteNonQuery(query As String) As Integer
        OpenConnection()

        Dim command As New MySqlCommand(query, connection)
        Dim result As Integer = command.ExecuteNonQuery()

        CloseConnection()

        Return result
    End Function

    ' Método para executar comandos com parâmetros
    Public Function ExecuteQueryWithParams(query As String, params As List(Of MySqlParameter)) As DataSet
        OpenConnection()

        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddRange(params.ToArray())

        Dim dataAdapter As New MySqlDataAdapter(command)
        Dim dataSet As New DataSet()
        dataAdapter.Fill(dataSet)

        CloseConnection()

        Return dataSet

    End Function
End Class

Public Module MyExtensions
    ' Método de extensão para executar SQL diretamente
    Public Function FastExecute(query As String, ParamArray parameters As Object()) As DataSet
        ' Se houver parâmetros, substitui as placeholders da consulta
        If parameters IsNot Nothing AndAlso parameters.Length > 0 Then
            For i As Integer = 0 To parameters.Length - 1
                query = query.Replace("{" & i & "}", parameters(i).ToString())
            Next
        End If

        ' Executa a consulta com ou sem parâmetros
        Dim dbHelper As New DbHelper()
        Return dbHelper.ExecuteQuery(query)
    End Function

    ' Método de extensão para executar comandos com parâmetros diretamente
    Public Function FastExecuteWithParams(query As String, ParamArray parameters As MySqlParameter()) As DataSet
        Dim dbHelper As New DbHelper()
        Return dbHelper.ExecuteQueryWithParams(query, parameters.ToList())
    End Function
End Module


