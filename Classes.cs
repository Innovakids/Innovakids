using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using Microsoft.VisualBasic;

using System.Collections;

using System.Data;
using System.Diagnostics;

using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;

using System.Text;
using System.Data.SqlClient;

// NOTE: If you change the class name "Service" here, you must also update the reference to "Service" in Web.config and in the associated .svc file.
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class Classes : IClasses
{

    
    public string GetData()
    {
        return string.Format("Hello World! It worked");
    }

  
    
     public string[][] GetClasses(string SchoolNo)
    {
        return new ClassUtility().GetClasses(SchoolNo,"");
    }
    
    
      public string[][] GetClassesFilter(string SchoolNo, string Filter)
    {
       
          Filter = Filter.Replace("~","'");
          
          return new ClassUtility().GetClasses(SchoolNo,Filter);
    }
    
       public string[][] GetClassesAdvanced(string SchoolNo, string Filter)
    {
       
          Filter = Filter.Replace("~","'");
          
          return new ClassUtility().GetClassesAdvanced(SchoolNo,Filter);
    }
    
    
      public string[][] GetClassClassNo(string SchoolNo, string ClassNo)
    {
        return new ClassUtility().GetClass(SchoolNo,"ClassNo = "+ClassNo);
    }
    
       
 
    

    
}



public class ClassUtility
{


    private const string connectionString = "Data Source=s02.winhost.com;Initial Catalog=DB_6956_innovakids;Persist Security Info=True;User ID=DB_6956_innovakids_user;Password=foll2164";
       

  
    
     public string[][] GetClasses(string SchoolNo,string argFilter)
    {
              
         
         if( argFilter == "" ) {
         
                    
             
             return GetClassDataString("Select Code,Class,Teacher,Room,ClassNo from class where schoolno  = '" + SchoolNo + "' and classyears = '2013-2014' AND SEMESTER = 'FALL' Order By Code",1,1000);
         }
         else
         {
                       
             
             return GetClassDataString("Select Code,Class,Teacher,Room,ClassNo from class where schoolno  = '" + SchoolNo + "' and "+argFilter+" Order By Code",1,1000);
             
         }
        

    }
    
     public string[][] GetClassesAdvanced(string SchoolNo,string argFilter)
    {
              
           return GetClassAdvancedDataString("Select Code,Class,Teacher,Room,ClassNo,Period,DayFrequency,ClassType,Subject,CurrentEnrollment,BegTime,EndTime from class where schoolno  = '" + SchoolNo + "' and "+argFilter+" Order By Code",1,1000);
             
       

    }
    
     public string[][] GetClass(string SchoolNo,string argFilter)
    {
   
        string[][] strReturn = GetClassNoDataString("Select Top 1 Code,Class,Teacher,Room,ClassNo from class where schoolno  = '" + SchoolNo + "' and "+argFilter,1,1);
             
       
        return strReturn;

    }
    
    //Classno
        public DataSet GetDataSet(string SQL, int PageNumber, int PageSize)
        {
                DataSet ds = null;
                SqlConnection Connection = new SqlConnection(connectionString);
                try {
                        Connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = new SqlCommand(SQL);

                        adapter.SelectCommand.Connection = Connection;
                        if (PageSize > 0) {
                                // Set rowcount =PageNumber * PageSize for best performance
                                long RowCount = PageNumber * PageSize;
                                SqlCommand cmd = new SqlCommand("SET ROWCOUNT " + RowCount.ToString() + " SET NO_BROWSETABLE ON", (SqlConnection)Connection);
                                cmd.ExecuteNonQuery();
                        }
                        ds = new DataSet();
                        adapter.Fill(ds, (PageNumber - 1) * PageSize, PageSize, "Data");
                        adapter.FillSchema(ds, SchemaType.Mapped, "DataSchema");
                
                } catch (Exception err) {
                        throw err;
                } finally {
                        Connection.Close();
                }
                return ds;
        }

    public String[][] GetClassNoDataString(string SQL, int PageNumber, int PageSize)
    {
        DataSet ds = null;
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(SQL);

            adapter.SelectCommand.Connection = Connection;
            if (PageSize > 0)
            {
                // Set rowcount =PageNumber * PageSize for best performance
                long RowCount = PageNumber * PageSize;
                SqlCommand cmd = new SqlCommand("SET ROWCOUNT " + RowCount.ToString() + " SET NO_BROWSETABLE ON", (SqlConnection)Connection);
                cmd.ExecuteNonQuery();
            }
            ds = new DataSet();
            adapter.Fill(ds, (PageNumber - 1) * PageSize, PageSize, "Data");
            adapter.FillSchema(ds, SchemaType.Mapped, "DataSchema");
            //If PageSize > 0 Then
            //    ' Reset Rowcount back to 0
            //    Dim cmd As New SqlCommand("SET ROWCOUNT 0 SET NO_BROWSETABLE OFF", DirectCast(Connection, SqlConnection))
            //    cmd.ExecuteNonQuery()
            //End If
            //If ds.Tables.Count > 1 Then
            //    Dim data As DataTable = ds.Tables("Data")
            //    Dim schema As DataTable = ds.Tables("DataSchema")
            //    data.Merge(schema)
            //    ds.Tables.Remove(schema)
            //End If
        }
        catch (Exception err)
        {
            throw err;
        }
        finally
        {
            Connection.Close();
        }

              
        
         List<string> strClasses = new List<string>();

        
        foreach( System.Data.DataRow row in ds.Tables[0].Rows )//or similar
         {
                       
            
            strClasses.Add(row[4].ToString()+","+ row[0].ToString()+","+row[1].ToString()+","+row[2].ToString()+","+row[3].ToString() );
                        
            
         }
        
       

        string[][] Arr = new string[strClasses.Count][];

        for (int x = 0; x < strClasses.Count; x++)
        {
            string[] values = strClasses[x].Split(',').ToArray();

            Arr[x] = values;
        }

        
        
        return Arr;
    }

        

    public String[][] GetClassDataString(string SQL, int PageNumber, int PageSize)
    {
        DataSet ds = null;
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(SQL);

            adapter.SelectCommand.Connection = Connection;
            if (PageSize > 0)
            {
                // Set rowcount =PageNumber * PageSize for best performance
                long RowCount = PageNumber * PageSize;
                SqlCommand cmd = new SqlCommand("SET ROWCOUNT " + RowCount.ToString() + " SET NO_BROWSETABLE ON", (SqlConnection)Connection);
                cmd.ExecuteNonQuery();
            }
            ds = new DataSet();
            adapter.Fill(ds, (PageNumber - 1) * PageSize, PageSize, "Data");
            adapter.FillSchema(ds, SchemaType.Mapped, "DataSchema");
            //If PageSize > 0 Then
            //    ' Reset Rowcount back to 0
            //    Dim cmd As New SqlCommand("SET ROWCOUNT 0 SET NO_BROWSETABLE OFF", DirectCast(Connection, SqlConnection))
            //    cmd.ExecuteNonQuery()
            //End If
            //If ds.Tables.Count > 1 Then
            //    Dim data As DataTable = ds.Tables("Data")
            //    Dim schema As DataTable = ds.Tables("DataSchema")
            //    data.Merge(schema)
            //    ds.Tables.Remove(schema)
            //End If
        }
        catch (Exception err)
        {
            throw err;
        }
        finally
        {
            Connection.Close();
        }

              
        
         List<string> strClasses = new List<string>();

        
        foreach( System.Data.DataRow row in ds.Tables[0].Rows )//or similar
         {
                       
            
            strClasses.Add("<a href='javascript:OpenClassEdit("+row[4].ToString()+");' >"+ row[0].ToString()+"</a>,"+row[1].ToString()+","+row[2].ToString()+","+row[3].ToString() );
                        
            
         }
        
       

        string[][] Arr = new string[strClasses.Count][];

        for (int x = 0; x < strClasses.Count; x++)
        {
            string[] values = strClasses[x].Split(',').ToArray();

            Arr[x] = values;
        }

        
        
        
        
        
        return Arr;
    }
    
    
     public String[][] GetClassAdvancedDataString(string SQL, int PageNumber, int PageSize)
    {
        DataSet ds = null;
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(SQL);

            adapter.SelectCommand.Connection = Connection;
            if (PageSize > 0)
            {
                // Set rowcount =PageNumber * PageSize for best performance
                long RowCount = PageNumber * PageSize;
                SqlCommand cmd = new SqlCommand("SET ROWCOUNT " + RowCount.ToString() + " SET NO_BROWSETABLE ON", (SqlConnection)Connection);
                cmd.ExecuteNonQuery();
            }
            ds = new DataSet();
            adapter.Fill(ds, (PageNumber - 1) * PageSize, PageSize, "Data");
            adapter.FillSchema(ds, SchemaType.Mapped, "DataSchema");
            //If PageSize > 0 Then
            //    ' Reset Rowcount back to 0
            //    Dim cmd As New SqlCommand("SET ROWCOUNT 0 SET NO_BROWSETABLE OFF", DirectCast(Connection, SqlConnection))
            //    cmd.ExecuteNonQuery()
            //End If
            //If ds.Tables.Count > 1 Then
            //    Dim data As DataTable = ds.Tables("Data")
            //    Dim schema As DataTable = ds.Tables("DataSchema")
            //    data.Merge(schema)
            //    ds.Tables.Remove(schema)
            //End If
        }
        catch (Exception err)
        {
            throw err;
        }
        finally
        {
            Connection.Close();
        }

              
        
         List<string> strClasses = new List<string>();

        
        foreach( System.Data.DataRow row in ds.Tables[0].Rows )//or similar
         {
                       
            
            strClasses.Add("<a href='javascript:OpenClassEdit("+row[4].ToString()+");' >"+ row[0].ToString()+"</a>,"+row[1].ToString()+","+row[2].ToString()+","+row[3].ToString()+","+row[5].ToString()+","+row[6].ToString()+","+row[7].ToString()+","+row[8].ToString()+","+row[9].ToString()+","+row[10].ToString()+","+row[11].ToString()+","+row[12].ToString() );
                        
            
         }
        
       

        string[][] Arr = new string[strClasses.Count][];

        for (int x = 0; x < strClasses.Count; x++)
        {
            string[] values = strClasses[x].Split(',').ToArray();

            Arr[x] = values;
        }

        
        
        
        
        
        return Arr;
    }
    
    
    public String GetDataString(string SQL, int PageNumber, int PageSize)
    {
        DataSet ds = null;
        SqlConnection Connection = new SqlConnection(connectionString);
        try
        {
            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(SQL);

            adapter.SelectCommand.Connection = Connection;
            if (PageSize > 0)
            {
                // Set rowcount =PageNumber * PageSize for best performance
                long RowCount = PageNumber * PageSize;
                SqlCommand cmd = new SqlCommand("SET ROWCOUNT " + RowCount.ToString() + " SET NO_BROWSETABLE ON", (SqlConnection)Connection);
                cmd.ExecuteNonQuery();
            }
            ds = new DataSet();
            adapter.Fill(ds, (PageNumber - 1) * PageSize, PageSize, "Data");
            adapter.FillSchema(ds, SchemaType.Mapped, "DataSchema");
            //If PageSize > 0 Then
            //    ' Reset Rowcount back to 0
            //    Dim cmd As New SqlCommand("SET ROWCOUNT 0 SET NO_BROWSETABLE OFF", DirectCast(Connection, SqlConnection))
            //    cmd.ExecuteNonQuery()
            //End If
            //If ds.Tables.Count > 1 Then
            //    Dim data As DataTable = ds.Tables("Data")
            //    Dim schema As DataTable = ds.Tables("DataSchema")
            //    data.Merge(schema)
            //    ds.Tables.Remove(schema)
            //End If
        }
        catch (Exception err)
        {
            throw err;
        }
        finally
        {
            Connection.Close();
        }


        string strReturn = ds.Tables[0].Rows[0]["DISTRICT"].ToString() + "," + ds.Tables[0].Rows[0]["SCHOOL"].ToString() + "," + ds.Tables[0].Rows[0]["NAME"].ToString() + "," + ds.Tables[0].Rows[0]["SCHOOLNO"].ToString();


        return strReturn;
    }


        public bool ExecuteSql(string SQL)
        {
                bool blnReturn = true;

                SqlConnection Connection = new SqlConnection(connectionString);
                try {
                        Connection.Open();

                        SqlCommand cmd = new SqlCommand(SQL, (SqlConnection)Connection);
                        cmd.ExecuteNonQuery();

                } catch (Exception err) {
                        blnReturn = false;
                } finally {
                        Connection.Close();
                }
                return blnReturn;
        }

        public string ExecuteScalar(string SQL)
        {
                string strReturn = "";

                SqlConnection Connection = new SqlConnection(connectionString);
                try {
                        Connection.Open();

                        SqlCommand cmd = new SqlCommand(SQL, (SqlConnection)Connection);

          
            strReturn = cmd.ExecuteScalar().ToString();

                } catch (Exception err) {
                        strReturn = "";
                } finally {
                        Connection.Close();
                }
                return strReturn;
        }


}

