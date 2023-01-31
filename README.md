# expense-management-app
 
<h1>Description</h1>
What this app does?
<ul>
 <li>Create categories of expenses and incomes</li>
 <li>Create transactions with category</li>
 <li>Showing how much money you have in your account from all incomes</li>
 <li>Showing how much money you spend</li>
 <li>Calculate balance</li>
 <li>Showing graph of last 7 days incomes and expenses</li>
 <li>Manage your account</li>
</ul>

<h1>Used technologies</h1>
<ul>
 <li>Application is build in ASP.NET Core MVC Framework</li>
 <li>Entity Framework</li>
 <li>Syncfusion</li>	
 <li>C#</li>
 <li>HTML, CSS, JS</li>
 <li>Microsoft SQL Server</li>
</ul>

<h1>My biggest challenges at building this app</h1>
<ul>
 <li>Problems with Entity Framework libraries</li>
 I can't create Controller for transactions, after cleaning nuget data and change versions of packages from 6.0.12 to 6.0.13 everything works fine.
 <li></li>
 <li></li>
 <li></li>
 <li></li>
</ul>

<h1>Application look</h1>
<b>Login page</b>
<img src="https://user-images.githubusercontent.com/101508780/215560591-6ea2cca8-8ae2-4cdf-820f-bf3eb1c27bd9.png"/>
<ul>
 <li>This is deafult page after running app if session is expired and user is log out</li><br/>
 <li>If user forgot password they can resart it by clicking red button and write old and new password</li><br/>
 <li>If the user forgets the password, he can reset it by clicking the red button and completing the appropriate form.</li><br/>
 <li>If there is a new user here, he can create his account by clicking the green button and entering his e-mail address and password (telephone number and other data can be added in the account configuration panel after logging in)
</li><br/>
 <li>Gray button is used for resending email confirmation to mail</li><br/>
</ul>
<b>Home page (Dashboard)</b>
<img src="https://user-images.githubusercontent.com/101508780/215774254-1bf68589-5160-47e7-9af6-74bd02d68b27.png"/>
<ul>
 <li>After logging in, this is the first page that is displayed.</li><br/>
 <li>On the left there is a sidebar displaying the username, a button to log out and buttons to other pages</li><br/>
 <li>There are 3 windows upstairs. One showing the sum of income, the second the sum of expenses and the third balance.</li><br/>
 <li>Below is a donut chart showing all expenses by category.</li><br/>
 <li>Next is a chart comparing your spending and income history for the last 7 days. When you hover over the graph, it shows the date and amount of income and expenses.</li><br/>
 <li>At the bottom, the last 5 expenses are shown by category, date and price.</li><br/>
</ul>
<b>Categories list page</b>
<img src="https://user-images.githubusercontent.com/101508780/215779500-302ff776-1e29-4e41-ba56-5f00b41efc20.png"/>
<ul>
 <li>This page lists all created categories stored in the database. There are two options on the right: edit and delete.</li><br/>
 <li>After clicking delete button message is displayed whether you are sure to delete the category</li><br/>
  <b>Delete message</b>
  <img src="https://user-images.githubusercontent.com/101508780/215782783-7925651c-1d01-4795-be9f-a2d2233afd2b.png"/>
 <li>When you click on the pen icon, the button redirects you to the category edit page.</li><br/>
 <b>Edit category page</b>
 <img src="https://user-images.githubusercontent.com/101508780/215785717-3110e431-6332-4242-9197-291e00c8a008.png"/>
 <li>The user can change whether it is an income or expense category, title and icon. After clicking the Submit button, the changes are saved to the database and are changed.
</li><br/>
 <b>Create category page</b>
 <img src="https://user-images.githubusercontent.com/101508780/215793835-20379359-6563-4221-80c6-9e6437b31a6e.png"/>
 <li>The user can create a new category by clicking the green New category button.</li><br/>
 <li>After clicking the Submit button, a new category is created and saved to the database.</li><br/>
 <li>The title and icon fields are required.</li><br/>
</ul>
<b>Transactions list page</b>
<img src="https://user-images.githubusercontent.com/101508780/215800361-d96a57da-d127-4962-a9c1-fc4888468495.png"/>
<ul>
 <li>The transaction page displays all added transactions.</li><br/>
 <li>As in the case of categories, it can be deleted and edited.</li><br/>
 <b>Edit transaction page</b>
 <img src="https://user-images.githubusercontent.com/101508780/215801934-41a2ab9e-4a43-4ca1-9162-5d37d004d192.png"/>
 <ul>The user can change:
  <li>Date</li>
  <li>Category</li>
  <li>Amount of money</li>
  <li>Note</li>
 </ul>
 <li>On the page with the list of transactions, after clicking the New Transaction button, you are redirected to the transaction wizard page.</li>
 <ul>
  <li>The date is selected first. The default is today's date.</li>
  <b>Create transaction page - Date</b><br/>
  <img src="https://user-images.githubusercontent.com/101508780/215812588-8b78bf64-1569-4a36-9a3c-df4c4f6bfdb9.png"/>
  <li>Next is the category to choose from. The entire list of previously created categories is presented.</li>
  <b>Create transaction page - Category</b>
  <img src="https://user-images.githubusercontent.com/101508780/215813354-3f9b2a0f-9ea2-49b8-b4e8-d2ab7392dfc3.png"/>
  <li>Next is the amount of money.</li>
  <b>Create transaction page - Amount</b>
  <img src="https://user-images.githubusercontent.com/101508780/215814938-2576be8e-db92-40f3-b607-d9c65130b1c8.png"/>
  <li>And last is note.</li>
  <b>Create transaction page - Note</b>
  <img src="https://user-images.githubusercontent.com/101508780/215815285-9fe7e43e-9ccf-4c79-acbc-2fece5630918.png"/>
  <li>After clicking Submit button and and complete all fields transaction is saved to database.</li>
 </ul>
</ul>
