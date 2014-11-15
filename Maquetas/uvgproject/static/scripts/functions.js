$(document).ready(function()
{
	var date = new Date();
    var day = date.getDate();
    var month = date.getMonth() + 1;
    var year = date.getFullYear();
	var name = date.getDay();
	var sunday;
	var monday;
	var tuesday;
	var wednesday;
	var thursday;
	var friday;
	var saturday;

    if (month < 10) month = "0" + month;
    if (day < 10) day = "0" + day;

    var today = year + "-" + month + "-" + day;       
	
	if (name ==0)
	{
		monday = year + "-" + month + "-" + (day-6);
		tuesday = year + "-" + month + "-" + (day-5);
		wednesday = year + "-" + month + "-" + (day-4);
		thursday = year + "-" + month + "-" + (day-3);
		friday = year + "-" + month + "-" + (day-2);
		saturday = year + "-" + month + "-" + (day-1);
		sunday = today;
	}
	if (name == 1)
	{
		monday = today;
		tuesday = year + "-" + month + "-" + (day+1);
		wednesday = year + "-" + month + "-" + (day+2);
		thursday = year + "-" + month + "-" + (day+3);
		friday = year + "-" + month + "-" + (day+4);
		saturday = year + "-" + month + "-" + (day+5);
		sunday = year + "-" + month + "-" + (day+6);
	}
	if (name == 2)
	{
		monday = year + "-" + month + "-" + (day-1);
		tuesday = today;
		wednesday = year + "-" + month + "-" + (day+1);
		thursday = year + "-" + month + "-" + (day+2);
		friday = year + "-" + month + "-" + (day+3);
		saturday = year + "-" + month + "-" + (day+4);	
		sunday = year + "-" + month + "-" + (day+5);
	}
	if (name == 3)
	{
		monday = year + "-" + month + "-" + (day-2);
		tuesday = year + "-" + month + "-" + (day-1);
		wednesday = today;
		thursday = year + "-" + month + "-" + (day+1);
		friday = year + "-" + month + "-" + (day+2);
		saturday = year + "-" + month + "-" + (day+3);	
		sunday = year + "-" + month + "-" + (day+4);
	}
	if (name == 4)
	{
		monday = year + "-" + month + "-" + (day-3);
		tuesday = year + "-" + month + "-" + (day-2);
		wednesday = year + "-" + month + "-" + (day-1);
		thursday = today;
		friday = year + "-" + month + "-" + (day+1);
		saturday = year + "-" + month + "-" + (day+2);
		sunday = year + "-" + month + "-" + (day+3);
	}
	if (name == 5)
	{
		monday = year + "-" + month + "-" + (day-4);
		tuesday = year + "-" + month + "-" + (day-3);
		wednesday = year + "-" + month + "-" + (day-2);
		thursday = year + "-" + month + "-" + (day-1);
		friday = today;
		saturday = year + "-" + month + "-" + (day+1);
		sunday = year + "-" + month + "-" + (day+2);
	}
	if (name == 6)
	{
		monday = year + "-" + month + "-" + (day-5);
		tuesday = year + "-" + month + "-" + (day-4);
		wednesday = year + "-" + month + "-" + (day-3);
		thursday = year + "-" + month + "-" + (day-2);
		friday = year + "-" + month + "-" + (day-1);
		saturday = today;
		sunday = year + "-" + month + "-" + (day+1);
	}
	
	$("#MonDate").attr("value", monday);
	$("#TueDate").attr("value", tuesday);
	$("#WedDate").attr("value", wednesday);
	$("#ThuDate").attr("value", thursday);
	$("#FriDate").attr("value", friday);
	$("#SatDate").attr("value", saturday);
	$("#SunDate").attr("value", sunday);
	
});

function onClickB(){}


