<script type="text/javascript">
function searchBack()
{
	window.history.back();
}
</script>
<?php
include("sqlconnect.php");
class RecordSearch extends sqlconnect
{
	function searchDate()
	{
		if($_POST['sdate'] <> "" and $_POST['edate'] <> "")
			{
		$beginDate = $_POST['sdate'];
		$endDate = $_POST['edate'];
		
		$a=explode("/", $beginDate);
		$b=explode("/", $endDate);
		
		$start_date=gregoriantojd($a[1], $a[2], $a[0]);
		$end_date=gregoriantojd($b[1], $b[2], $b[0]);
		$diff = $end_date - $start_date;
		
		$startDate = date("Y-m-d-D", mktime(0, 0, 0, $a[1], $a[2], $a[0]));
		$endDate = date("Y-m-d-D", mktime(0, 0, 0, $a[1],$a[2]+$diff,$a[0]));
		
		//This $temp[] array used to display to all the dates given by the user...
		
		for($i=0;$i<=$diff;$i++)
			{
				$temp[] = date("Y-m-d", mktime(0, 0, 0,$a[1], $a[2]+$i, $a[0]));
			}
	
		/*$query = mysql_query("SELECT evt_date FROM eventcalender") or die(mysql_error());
		
		// This $date[] araray used to display all the dates in the database....
		
		while($row = mysql_fetch_array($query))
			{
				$date[] = $row[0];
			}
	*/
	
		$flag = 1;
		
		for($j = 0;$j<count($temp);$j++)
			{
				
						$this->connection();
						
						$sql = "SELECT * FROM eventcalender WHERE evt_date ="."'".$temp[$j]."'";
						
						$squery = $this->ExecuteQuery($sql);
						
						while($srow = mysql_fetch_assoc($squery))
							{
								$output.= "<table border='0' align='center' cellpadding='0' cellspacing='0' width='100%'><tr class='tit'>";
								$output.="<td colspan='2' align='left'>Event Number:".$flag;
								$output.="</td></tr><tr>";
								$output.="<td>Title:</td><td>".$srow['evt_title'];
								$output.="</td></tr><tr>";
								$output.="<td>Date:</td><td>".$srow['evt_date'];
								$output.="</td></tr><tr>";
								$output.="<td>Start Time:</td><td>".$srow['evt_stime'];
								$output.="</td></tr><tr>";
								$output.="<td>End Time:</td><td>".$srow['evt_etime'];
								$output.="</td></tr><tr>";
								$output.="<td>Event Place:</td><td>".$srow['evt_place'];
								$output.="</td></tr><tr>";
								$output.="<td>Event Url:</td><td>"."<a href=".$srow['evt_contact'].">".$srow['evt_contact']."</a>";
								$output.="</td></tr><tr>";
								$output.="<td>Contact Person:</td><td>".$srow['evt_person'];
								$output.="</td></tr><tr>";
								$output.="<td>Contact Number</td><td>".$srow['evt_phone'];
								$output.="</td></tr><tr>";
								$output.="<td>Ticket Price:</td><td>".$srow['evt_ticket'];
								$output.="</td></tr><tr>";
								$output.="<td>Description:</td><td>".$srow['evt_desc'];
								$output.="</td></tr></table>";
								$flag++;
							}
						
					
				
			}
		$output.="<table border='0' cellpadding='0' cellspacing='0' width='100%'><tr class ='tit'><td colspan='2'>Total Events:".($flag-1)."</td></tr></table>";
		if($flag == 1)
			{
				$output.="<i><h2>No Events Found</h2></i>";
				$output.="<input type='button' value='back' onClick='searchBack()'>";
			}
				
			return $output;
			}
			else
			{
				$output.="<a href='../templates/search.php'>Plz select your days</a>";
				return $output;
			}
		}
	}
?>