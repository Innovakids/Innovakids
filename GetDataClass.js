$(function() {
 
      var Type;
         var Url;
         var Data;
         var ContentType;
         var DataType;
         var ProcessData;
    
    
    
        GetData();
    
      
        function GetData() {
             var schoolno = getCookie('schoolno');
             var strYear = getCookie('schoolyear');
             var strTerm = getCookie('schoolterm');
             var strFilter = getCookie('classesfilter');
            
            
            //Advanced
            var strclassteacherselect = getCookie('class-teacher-select');
             
            if( strclassteacherselect != "" )
            {
               strFilter = strFilter + " and TeacherNo = ~"+ strclassteacherselect+"~";
   
            }
                        
            
             var strclasslevelselect = getCookie('class-classlevel-select');
            
             
            
            if( strclasslevelselect != "" )
            {
               strFilter = strFilter + " and ClassLevel = ~"+ strclasslevelselect+"~";
   
            }
            
            
            var strclasssubjectselect = getCookie('class-subject-select');
             
            if( strclasssubjectselect != "" )
            {
               strFilter = strFilter + " and Subject = ~"+ strclasssubjectselect+"~";
   
            }
            
            
            var strclasstypeselect = getCookie('class-classtype-select');
 
            if( strclasstypeselect != "" )
            {
               strFilter = strFilter + " and ClassType = ~"+ strclasstypeselect+"~";
   
            }
            
             //alert(strFilter);
            
             //var strFilter = "";
              //' classyears = ~' + strYear + '~ and semester = ~' + strTerm + '~'; 
            
            
              
            
              if( schoolno == "" )
              {
                    alert("Please Reselect your school");
                    return;
              }
            
             Type = "POST";
             Url = "Classes.svc/GetClassesFilter";
            
                   
             Data = '{"SchoolNo": "' + schoolno + '","Filter": "' + strFilter + '"}';
            
            ContentType = "application/json; charset=utf-8";
             DataType = "json"; 
             ProcessData = true;
             CallService();
         }

   

       //Generic function to call AXMX/WCF  Service        
         function CallService() {
             $.ajax({
                 type: Type, //GET or POST or PUT or DELETE verb
                 url: Url, // Location of the service
                 data: Data, //Data sent to server
                 contentType: ContentType, // content type sent to server
                 dataType: DataType, //Expected data format from server
                 processdata: ProcessData, //True or False
                 success: function (msg) {//On Successfull service call
                     ServiceSucceeded(msg);
                 },
                 error: ServiceFailed// When Service call fails
             });
         }

         function ServiceFailed(result) {
             alert('Service call failed: ' + result.status + '' + result.statusText);
             Type = null; Url = null; Data = null; ContentType = null; DataType = null; ProcessData = null;
         }

    
    
         function ServiceSucceeded(result) {
           
                         
             if (DataType == "json") {

                 resultObject = result.GetClassesFilterResult;
                 
                 //alert(resultObject);
                 
                // var array = resultObject[0].split(',')
                
                  var table_1 = $('#table-1').dataTable ({
                     "aaData": resultObject,
                     "fnInitComplete": function(oSettings, json) {
      $(this).parents ('.dataTables_wrapper').find ('.dataTables_filter input').prop ('placeholder', 'Table Search...').addClass ('form-control input-sm')
                    }
             })
         

             }

         }

         function ServiceFailed(xhr) {
            
             alert("Failed");
             
             if (xhr.responseText) {
                 var err = xhr.responseText;
                 if (err)
                                   alert("Error Accessing Data");
                 else
                   alert("Unknown server error.");
             }
             return;
         }

         $(document).ready(
         function () {
             //WCFJSON();
         }
         );
    
    
   
    
    
})


