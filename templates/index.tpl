{config_load file="test.conf" section="setup"}

{include file="header.tpl" title=Innovakids}



<div id="wrapper">
   
  <div class="content">

 
    <div class="container">
        
        <div class="row">
                   
            
          <div class="col-md-3 col-sm-6">
   
              
            <div class="portlet">
                <h4 class="portlet-title">
                    <u>Admin Dashboard</u>
                </h4> 
                
              <!-- Info Panel  -->
              <h4 class="portlet-title">
   
                    <label for="UserName"  id="UserName" style="font-size:12px;color:black;font-weight:normal">User: {$UserName}</label>                     <br />
                    
                    <label for="Year" id="Year"  style="font-size:12px;color:black;font-weight:normal">School Year:</label><br />
                    <select id="class-classlevel-select" name="class-classlevel-select" class="class-classlevel form-control parsley-validated" data-required="true"  onchange="javascript:YearChangeEvent(this);">
                          {html_options values=$year_values selected=$year_selected output=$year_output}
                    </select>
                  <br />
                   <label for="Term" id="Term"  style="font-size:12px;color:black;font-weight:normal">Term:</label><br />
                    <select name=Term Width="200" class="class-teacher form-control parsley-validated" data-required="true"  onchange="javascript:TermChangeEvent(this);">
                          {html_options values=$term_values selected=$term_selected output=$term_output}
                    </select>
                  <br />
                  <label for="School" id="School" style="font-size:12px;color:black;font-weight:normal">Select School:</label><br />
                    <select name=School  Width="200"  name="class-teacher-select" class="class-teacher form-control parsley-validated" data-required="true" onchange="javascript:SchoolNoChangeEvent(this);">
                          {html_options values=$school_values selected=$school_selected output=$school_output}
                    </select>
                  <br />
                 
              </h4> 
                        
             
              <div class="list-group">  
               
              <a href="smart_admin_classes.php" class="list-group-item">
              <i class="fa fa-cog text-primary"></i> &nbsp;&nbsp;Classes
              <i class="fa fa-chevron-right list-group-chevron"></i><span class="badge">{$NumberOfClasses}</span>
            </a> 
                 </a> 
              <a href="account-activelessons.php" class="list-group-item">
              <i class="fa fa-cog text-primary"></i> &nbsp;&nbsp;Active Lessons

              <i class="fa fa-chevron-right list-group-chevron"></i><span class="badge">{$NumberOfActiveLessons}</span>
            </a> 
               </a> 
              <a href="account-parents.php" class="list-group-item">
              <i class="fa fa-cog text-primary"></i> &nbsp;&nbsp;Active Parents

              <i class="fa fa-chevron-right list-group-chevron"></i><span class="badge">{$NumberOfParents}</span>
            </a> 
             </a> 
              <a href="account-students.php" class="list-group-item">
              <i class="fa fa-cog text-primary"></i> &nbsp;&nbsp;Students

             <i class="fa fa-chevron-right list-group-chevron"></i><span class="badge">{$NumberOfStudents}</span>
            </a> 
               <a href="account-school.php" class="list-group-item">
              <i class="fa fa-cog text-primary"></i> &nbsp;&nbsp;Schools

              <i class="fa fa-chevron-right list-group-chevron"></i><span class="badge">{$NumberOfSchools}</span>
            </a> 
              <a href="account-schoolschedule.php" class="list-group-item">
              <i class="fa fa-cog text-primary"></i> &nbsp;&nbsp;School Schedule

              <i class="fa fa-chevron-right list-group-chevron"></i><span class="badge">{$NumberOfEvents}</span>
            </a> 
            </div> 
        </div>
    </div>
    
    
    
     <div class="col-md-8 col-sm-7">
           <div class="portlet">

                 <div class="alert alert-success">
            <a class="close" data-dismiss="alert" href="#" aria-hidden="true">&times;</a>
            <strong>Well done!</strong> Your classes are 52% Proficient.
          </div> <!-- /.alert -->
               
                <h4 class="content-title"><u>Reminders</u></h4>

               

               
               
           
               
             <ul class="icons-list">
                  <li>
                    <button type="button" class="btn btn-default demo-element ui-popover" data-toggle="tooltip" data-placement="top" data-trigger="hover" data-content="School: School award night, Thur Jan 28th, 7:30 Auditorium" title="View">
              View
              </button> School: School award night 
                  </li>  
                      
                      
                
                 <li>
                   <button type="button" class="btn btn-default demo-element ui-popover" data-toggle="tooltip" data-placement="top" data-trigger="hover" data-content="Meeting with Parent Thur Jan 28th, 8:30 Office" title="View">
              View
              </button> Personal: Meeting with Parent  
                  </li>
                 <li>
                   <button type="button" class="btn btn-default demo-element ui-popover" data-toggle="tooltip" data-placement="top" data-trigger="hover" data-content="Teach 8th Grade, Earth Science, Thur Jan 28th, 9:30 Room 222" title="View"> View
              </button> Class: Teach 8th Grade, Earth Science 
                  </li>
                </ul>
             <a href="account-profile.html">Read More &nbsp;<i class="fa fa-external-link"></i></a>
          <hr>


          
               
               
       <h4 class="content-title"><u>Recent Activity</u></h4>

            <div class="well">


              <ul class="icons-list text-md">

                <li>
                  <i class="icon-li fa fa-location-arrow"></i>

                  <u>Rod</u> uploaded 6 files. 
                  <br>
                  <small>about 4 hours ago</small>
                </li>

                <li>
                  <i class="icon-li fa fa-location-arrow"></i>

                  <u>Rod</u> followed the research interest: <a href="javascript:;">Open Access Books in Linguistics</a>. 
                  <br>
                  <small>about 23 hours ago</small>
                </li>

                <li>
                  <i class="icon-li fa fa-location-arrow"></i>

                  <u>Rod</u> added 51 papers. 
                  <br>
                  <small>2 days ago</small>
                </li>
              </ul>
 <a href="account-tasks.html">Read More &nbsp;<i class="fa fa-external-link"></i></a>
            </div> <!-- /.well -->


                    <h4 class="content-title"><u>World Wide Subject Discussions</u></h4>

             <ul class="icons-list">
                  <li>
                   <span class="label label-info demo-element">Info</span>Science: Conference on K12 Labs (Palm Springs Ca) Feb 12-16 2014, Thur Jan 28th, 7:30 
                  </li>
                 <li>
                   <span class="label label-info demo-element">Info</span>Math: New Holt Math 8th Grade Text Book Thur Jan 28th, 8:30 Office
                  </li>
                 <li>
                   <span class="label label-info demo-element">Info</span>Science: Web Seminar "Teaching with Boxes" www.mathk12.com 7pm (PST) , Thur Jan 28th, 9:30 Room 222
                  </li>
                </ul>
             <a href="account-profile.html">Read More &nbsp;<i class="fa fa-external-link"></i></a>
          <hr>
                    <ul class="icons-list"> 
               <li>
                  <h4 class="content-title"><u>Your Class Discussions Threads</u></h4>
    
                    <span class="badge badge-secondary demo-element">13 Comments</span>    
                   Ron (St. Mary's School MO): Are you going to the Conference in Palm Springs?, Thur Jan 28th, 7:30 
               </li>
                 <li>
                   <span class="badge badge-secondary demo-element">4 Comments</span> Lisa (STM College) Have you seen the latest Holt Math book Thur Jan 28th, 8:30 Office
                  </li>
                 <li>
                   <span class="badge badge-secondary demo-element">2 Comments</span> Mike (Chapman U) Do you know of a Lesson Plan teaching about Cells? Thur Jan 28th, 9:30 Room 222
                  </li>
                </ul>
             <a href="account-profile.html">Read More &nbsp;<i class="fa fa-external-link"></i></a>
          <hr>

              
              
       
               
        <div class="portlet-body">
        
            
           <h4 class="portlet-title">
                  <u>School Overview</u>
                </h4>
                <table class="table keyvalue-table">
                  <tbody>
                    <tr>
                      <td class="kv-key"><i class="fa fa-gift kv-icon kv-icon-secondary"></i><a href="mainmenu.html" > Registered</a></td>
                      <td class="kv-value">653 </td>
                    </tr>
                    <tr>
                      <td class="kv-key"><i class="fa fa-gift kv-icon kv-icon-secondary"></i><a href="mainmenu.html" > Enrolled this Term</a></td>
                      <td class="kv-value">473 </td>
                    </tr>
                    <tr>
                      <td class="kv-key"><i class="fa fa-gift kv-icon kv-icon-secondary"></i><a href="mainmenu.html" >Active Classes</a></td>
                      <td class="kv-value">78</td>
                    </tr>
                    <tr>
                      <td class="kv-key"><i class="fa fa-envelope-o kv-icon kv-icon-default"></i><a href="mainmenu.html" >Unread Messages</a> </td>
                      <td class="kv-value">39 </td>
                    </tr>
                  </tbody>
                </table>

        </div> <!-- /.portlet-body -->

      </div> <!-- /.portlet -->

          </div> <!-- /.col -->
    
    
    
    
    
  </div>
</div>
</div>                




{include file="footer.tpl"}
