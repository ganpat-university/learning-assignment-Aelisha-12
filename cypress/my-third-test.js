describe('Login Form Tests', () => {

	context('Testing the Login Form', () => {

			// TEST #1 -------------------------------------------------------------------------

			it('with Valid Credentials', () => {

				let userId = 'demo@demo.com';
				let password = 'Password@123';

				// Navigate to Home page, after opening the browser
				cy.visit('https://localhost:44311/');

				// Enforce step-by-step execution of Cypress
				cy.pause();

				// Check if the Home Page Title is correct.
				cy.title().should('eq', 'Home page - My University');

				// Check if the hyperlink element to authenticate user contains the text "Login"
				// and after asserting that, click the link.
				cy.get('a[href="/Identity/Account/Login"]').contains('Login').click();

				// Now check if the Login Page appears
				cy.title().should('eq', 'Log in - My University');

 				// Next enter valid login credentials into the two textboxes
				cy.get('div[id="Input_Email"]').type(userId);
				cy.get('input[id="Input_Password"]').type(password);

				cy.pause();

				// Click on the Login button
				cy.get('button[type="submit"]').click();

				//now check password
				cy.get('div[class="text-danger validation-summary-valid"]').contains("Invalid login attempt");

				// Now check if the UserName is reflected on the home page, to confirm successful login.
				cy.get('a[href="/Identity/Account/Manage"]').contains(userId);

				cy.pause();

				// Finally click on the Logout button
				cy.get('button').contains('Logout').click();

			});

	});

});