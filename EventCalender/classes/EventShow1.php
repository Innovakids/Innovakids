<script type="text/javascript">
function deleting()
{
	conf = confirm("Are you want to delete");
	if(conf == true)
		{
			return true;
		}
	else
		{
			return false;
		}
}
</script>
<?php
include("sqlconnect.php");
class EventShow extends sqlconnect
	{
		  function EventList()
			{

				
				$output="Date is:".date("M-d-Y");
				$edate = date("Y-m-d");
				
				$this->connection();
				
				$sql = "Select * from eventcalender where evt_date = '$edate'";
				
				$query = $this->ExecuteQuery($sql);
				
				$flag = 1;
				while($row = mysql_fetch_assoc($query))
					{
						$id = $row['evt_id'];
						$output.="<br><br>";
						$output.="<span class='tit'>Event number:".$flag."</span>";
						$output.="<table border='0'><tr>";
						$output.="<td>Title:</td><td>".$row['evt_title'];
						$output.="</td></tr><tr>";
						$output.="<td>Start Time:</td><td>".$row['evt_stime'];
						$output.="</td></tr><tr>";
						$output.="<td>End Time:</td><td>".$row['evt_etime'];
						$output.="</td></tr><tr>";
						$output.="<td>Event Place:</td><td>".$row['evt_place'];
						$output.="</td></tr><tr>";
						$output.="<td>Event Url:</td><td>"."<a href=".$row['evt_contact'].">".$row['evt_contact']."</a>";
						$output.="</td></tr><tr>";
						$output.="<td>Contact Person:</td><td>".$row['evt_person'];
						$output.="</td></tr><tr>";
						$output.="<td>Contact Number</td><td>".$row['evt_phone'];
						$output.="</td></tr><tr>";
						$output.="<td>Ticket Price:</td><td>".$row['evt_ticket'];
						$output.="</td></tr><tr>";
						$output.="<td>Description:</td><td>".$row['evt_desc'];
						$output.="</td></tr><tr>";
						$output.="<td colspan='2'><a href='classes/DeleteEvent.php?id=$id' onClick='return deleting()'><h2>Delete</h2></a>";
						$output.="</td></tr></table>";
						
						$flag++;
					}
				$output.="<br>";
				$output.="Today's Event:".($flag-1);
				return $output;
			}
	}
?>