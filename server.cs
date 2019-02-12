if ( LoadRequiredAddOn ("Support_Lightning") == $Error::None )
{
	exec ("./Lightning_Default.cs");
}
else
{
	error ("ERROR: Missing required add-on Support_Lightning!");
	messageAll ('', "Lightning_Default - ERROR: Missing required add-on Support_Lightning!");
}
