<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<title>Events Calender</title>
<script src="../js/ExceptDate.js" type="text/javascript"></script>
<link href="../css/style.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="calendar.js"></script>
<script type="text/javascript" src="calendar-setup.js"></script>
<script type="text/javascript" src="lang/calendar-en.js"></script>
<style type="text/css"> @import url("calendar-win2k-cold-1.css"); </style>
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
        <td class="tit">EVENT SEARCH </td>
      </tr>
      <tr>
        <td><form name="eventRecord" method="post" action="SearchResultPage.php"><table width="100%" border="0" cellpadding="0" cellspacing="0" class="box">
            <tr>
            <td height="91">
            <table style="height: 100%; width: 100%;" cellspacing="0" cellpadding="0" align="center">
      		<tr style="height: 100%;">
        	<td width="48%" height="144" style="vertical-align: top; text-align: left;">
          	<div align="center">From :&nbsp;
            <input type="text" id="cal-field-1" name="sdate" />
            <button type="submit" id="cal-button-1">...</i></button>
            <br>
            <br>
            To &nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;
            <input type="text" id="cal-field-2" name="edate" />
            <button type="submit" id="cal-button-2">...</button>
          	</div>
          	<p align="center">
            <script type="text/javascript">
            Calendar.setup({
              inputField    : "cal-field-1",
              button        : "cal-button-1",
              align         : "Tr"
            });
          	</script>
            <input type="submit" value="Search" />
          	</p>
          	<p align="center">&nbsp;  </p>
          
          	<script type="text/javascript">
            Calendar.setup({
              inputField    : "cal-field-2",
              button        : "cal-button-2"
            });
          	</script></td>
        	</tr>
    		</table>
            </td>
                
            </tr>
        	</table>
    		</form>
       </td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td>&nbsp;</td>
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

