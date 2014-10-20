
The Troubleshooting folder in your application contains a number of web pages 
that test various aspects of your configuration to make sure that everything 
is working correctly.


PURPOSE:

These tests use generic Microsoft .NET Framework code.  No Iron Speed Designer
specific code is used in these tests.  A test that fails generally indicates a
configuration problem with your system.


DELETE AFTER DEPLOYMENT:

Once your application has been tested and deployed, this folder can be deleted 
in its entirety without any problems.  No part of your application is dependent
on any files in this folder.


TESTS INCLUDED:

The following tests are included in the system.

Test0: Calls Response.Write ASPX function to test if a basic ASPX page can be
displayed.  If this test fails then most likely Microsoft .NET Framework is not
installed or not configured properly.

Test1: A more advanced Microsoft .NET Framework test.  This test prints out
a number of server variables indicating the version of Microsoft .NET Framework,
the version of the browser, etc.  If this test fails, then most likely 
Microsoft .NET Framework is not installed or configured properly.

Test2: This test checks to see if the Microsoft Access database can be properly
accessed and used by your application.  If this test fails, then it could be
because (1) the virtual directory has not been created; (2) the user account
under which your application is running does not have read/write access to the 
Microsoft Access database file or folder; or (3) the user account does not
have read/write access to the temporary folder of your Windows server.

Test3: This test checks to see if you can access the Microsoft SQL Server database.
If this test fails, then it could be because (1) you are using Windows Authentication
in Impersonate mode and the SQL Server and is located on a different machine 
(double hops are not allowed); (2) you are using Windows Authentication
in Impersonate mode and the user connecting to the application does not have
access to the SQL Server; (3) you are using SQL Server authentication and your
server does not recognize the user name and password.

In all of these cases, you can search the Knowledge Base with the text of
the error message to find a solution to the problem.  The knowledge base is
available at http://www.ironspeed.com/kb.

Updated: 9/21/2005

