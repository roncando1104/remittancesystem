Imports Oracle.ManagedDataAccess.Client

Module DBConnectionModule

    Dim OraDB As String = "Data Source= (DESCRIPTION =" _
            + "(ADDRESS=(PROTOCOL=TCP) (HOST=localhost) (PORT=1521))" _
            + "(CONNECT_DATA=(SERVICE_NAME=ORCL)));" _
            + "User Id=SYSTEM;Password=SYSTEM;"

    Dim conn As New OracleConnection(OraDB)
    'conn.ConnectionString = OraDB

End Module
