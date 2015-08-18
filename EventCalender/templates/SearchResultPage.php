<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Events Calender</title>
<script src="../js/ExceptDate.js" type="text/javascript"></script>
<link href="../css/style.css" rel="stylesheet" type="text/css" />
</head>
<body>
<table width="900" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td class="header"><a href="../index.php"><img src="../images/header_1.jpg" width="328" height="149" border="0" /></a></td>
  </tr>
  <tr>
    <td><table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td class="tit">SEARCH RESULTS</td>
      </tr>
      <tr>
        <td><table width="100%" border="0" cellpadding="0" cellspacing="0" class="box">
            <tr>
              <td height="39">
              	
                <?php
                	include("../classes/RecordSearch.php");
					$obj = new RecordSearch();
					echo $obj->searchDate();
				?>				</td>
            </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td class="btm"><a href="http://www.ajsquare.com">Ajsquare Inc </a></td>
  </tr>
  <tr>
    <td>&nbsp;</td>
  </tr>
</table>
</body>
</html>