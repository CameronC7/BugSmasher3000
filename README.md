---


---

<h1 id="bug-smasher-3000">Bug Smasher 3000</h1>
<h2 id="table-of-contents">Table of Contents</h2>
<ol>
<li><a href="#Concept-Description">Concept Description</a></li>
<li><a href="#Database-Diagrams">Database Diagrams</a></li>
<li><a href="#Wire-Frames">Wire Frames</a></li>
<li><a href="#Requirements-and-Use-Cases">Requirements and Use Cases</a></li>
<li><a href="#Test-Table">Test Table</a></li>
<li><a href="#Prototype">Prototypes</a></li>
<li><a href="#Database-Migration">Database Migration</a></li>
</ol>
<h1 id="concept-description">Concept Description</h1>
<p>This web application I am building will help keep track of bugs, or errors, in software applications.  The goal is to build this great software and then it will help me when I build more projects in the future by keeping track of all bugs that show up and reduce the time needed to fix those problems.</p>
<p>My application will have a theoretical company using this application, including fake employee names with different account permissions, depending on the title of the employee.  The employees will need to log-in to use the application.  “Users” of this company’s product will also be able to submit bugs they found while using the product. The user’s report will be screened and if the problem is valid, will be added to the bug tracking application.</p>
<h1 id="database-diagrams">Database Diagrams</h1>
<p>The database will be written and maintained in SQL Server and will be hosted on Microsoft Azure.</p>
<p>Here is an ERD Diagram of the database:<br>
<img src="https://i.ibb.co/4KZr929/ERD-2-0.jpg" alt="ERD Diagram"></p>
<h1 id="wire-frames">Wire Frames</h1>
<p>Here are some wire frame drafts of the application.<br>
This is the login page:<br>
<img src="https://i.ibb.co/z4vYchj/Login-Wireframe.png" alt="Login Wireframe"></p>
<p>This is an example of what it will look like when looking at a bug ticket:<br>
<img src="https://i.ibb.co/n16bRq6/Ticket-Wireframe.png" alt="Ticket Example"></p>
<h1 id="requirements-and-use-cases">Requirements and Use Cases</h1>
<h2 id="user-stories">User Stories</h2>
<p>Here are a few user stories:</p>
<ol>
<li>As an employee, I need to be able to write comments on the bugs I am tracking so that my supervisor and I can see the progress I am making on fixing the issue.</li>
<li>As a supervisor, I need to be able to assign bug tickets to certain employees, so that the best employee for that issue is fixing that issue.</li>
<li>As a supervisor, I want a board that shows every employee’s name and what bug tickets are assigned to them, so that I can track what each person is working on all in one location.</li>
<li>As an admin, I need to be able to assign employees with the appropriate permissions, so that each role is only allowed to see what they are supposed to see.</li>
</ol>
<h2 id="use-cases">Use Cases</h2>
<p>Here are some use cases:</p>
<ol>
<li>
<p>Log In. Actor: All users. Given all users who use this website need to log in to use it, when the user pulls up the website they will have the log in form on their screen, then they must enter their username and password and click log in.</p>
</li>
<li>
<p>Write Comments.  Actor: Employee.  Given an employee is assigned a bug ticket to fix a certain issue, when he makes progress or fixes the issue he writes a comment to showcase his progress, then his supervisor is able to track his progress and his co-workers will be able to read what he did once the ticket goes to the historical section.</p>
</li>
<li>
<p>Assign tickets.  Actor: Supervisor.  Given the supervisor receives a new bug ticket and reads the description of the issue, when he decides one specific employee is the best person to fix the issue, then he assigns that ticket for that employee to fix and the ticket goes into that employee’s list of tickets.</p>
</li>
<li>
<p>Track Progress.  Actor: Supervisor.  Given the supervisor wants to track all employees at once, when he clicks on the tab “The Board”, then the screen will show a board with each of his employee’s name at the top and underneath each employee will have a post- it note for each bug ticket they are currently working on with the title of that bug ticket.</p>
</li>
<li>
<p>Assign role.  Actor: Admin.  Given an employee has been promoted or an employee has left the company, when the admin click’s on that employee’s profile, then he is able to adjust their role in the system to give them the proper permissions so they can only see what they’re allowed to see.</p>
</li>
</ol>
<h2 id="uml-use-case-diagram">Use Case Diagram</h2>
<p><img src="https://i.ibb.co/Ms39Sz4/UML-Diagram.jpg" alt="enter image description here"></p>
<h2 id="system-requirements">System Requirements</h2>
<p>1.0.0: System shall request users to log in to enter website.</p>
<ul>
<li>1.1.0: System shall verify users input for username and password.
<ul>
<li>1.1.1: System shall display error message if username and password doesn’t match database.</li>
<li>1.1.2: System shall allow user to request their password be emailed to them if they forgot it.</li>
</ul>
</li>
</ul>
<p>2.0.0: System shall display different options depending on user’s role.</p>
<ul>
<li>2.1.0: System shall display all windows and options for user’s with admin role.</li>
<li>2.2.0: System shall display all windows and options besides assigning employee’s roles for user’s with supervisor role</li>
<li>2.3.0: System shall display only the employee’s tickets assigned to him for user’s with employee role.</li>
</ul>
<p>3.0.0: System shall allow bug tickets to be tracked and fixed.</p>
<ul>
<li>3.1.0: System shall allow supervisors to assign bug tickets to specific employee.</li>
<li>3.2.0: System shall allow employees to write comments on their tickets to show progress.
<ul>
<li>3.2.1: System shall put all active tickets on a board for the supervisor to track all active tickets.</li>
</ul>
</li>
<li>3.3.0: System shall store all fixed tickets in a historical section.
<ul>
<li>3.3.1: System shall allow users to search historical section by title or category.</li>
</ul>
</li>
</ul>
<h1 id="test-table">Test Table</h1>

<table>
<thead>
<tr>
<th align="left">Test ID</th>
<th align="right">Requirement ID</th>
<th align="center">Test Procedure</th>
<th align="right">Current Status</th>
<th align="right">Time Stamp</th>
</tr>
</thead>
<tbody>
<tr>
<td align="left">1</td>
<td align="right">1.1.0</td>
<td align="center">Test log in with correct email and password</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">2</td>
<td align="right">1.1.1</td>
<td align="center">Test log in with incorrect email and password</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">3</td>
<td align="right">1.1.2</td>
<td align="center">Make sure password reset is sent to user’s email upon request</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">4</td>
<td align="right">2.1.0</td>
<td align="center">Log in with admin account and ensure profile has access to everything</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">5</td>
<td align="right">2.2.0</td>
<td align="center">Log in with supervisor account and ensure profile has access to track all tickets</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">6</td>
<td align="right">2.3.0</td>
<td align="center">Log in with employee account and ensure profile only has access to their tickets</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">7</td>
<td align="right">3.1.0</td>
<td align="center">While logged into a supervisor profile, assign a test ticket to an employee</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">8</td>
<td align="right">3.2.0</td>
<td align="center">While logged into an employee profile, write comments on active ticket</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">9</td>
<td align="right">3.2.1</td>
<td align="center">Verify all active tickets are on “The Board” under the assigned employee’s name</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">10</td>
<td align="right">3.3.0</td>
<td align="center">Complete test tickets and verify they are stored in the historical section</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
<tr>
<td align="left">11</td>
<td align="right">3.3.1</td>
<td align="center">Verify search bar returns correct historical ticket by title</td>
<td align="right">Not Tested</td>
<td align="right"></td>
</tr>
</tbody>
</table><pre><code></code></pre>

<h1 id="Prototype">Prototypes</h1>
<p>Here is a prototype for the log in page and bug ticket description page <a href="https://pr.to/FT5E47/">Click Here</a></p>

<h1 id="Database-Migration">Database Migration</h1>
<p>Here is the data being shown in SSMS</p>
<p><img src="https://i.ibb.co/209B9FG/SSMS.jpg" alt="enter image description here"></p>
<p>And here is the employee table being displayed on the Users view</p>
<p><img src="https://i.ibb.co/ZBgcMZw/Employee-table.jpg" alt="enter image description here"></p>
