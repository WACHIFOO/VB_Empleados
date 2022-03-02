Imports MySql.Data.MySqlClient

Module DBConnection
    Public Function strstconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;database=employeedb")
    End Function

    Public strcon As MySqlConnection = strstconnection()
End Module
