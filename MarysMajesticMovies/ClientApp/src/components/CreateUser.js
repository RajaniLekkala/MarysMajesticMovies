import React from 'react';

export class CreateUser extends Component {
    static displayName = CreateUser.name;

    constructor(props) {
    }

    render() {
        return (
            <div>
                <div class="banner3"></div>
                <div class="register">
                    <h1> Create an account </h1>
                    <form>
                        <label for="fname">Name</label><br>
                        <input type="text" id="fname" name="fname" placeholder="First name*"><br>
                        <input type="text" id="lname" name="lname" placeholder="Last name*"><br><br>

                        <label for="fname">Billing and shippingadress</label><br>
                        <input type="text" id="adress" name="adress" placeholder="Adress*"><br>
                        <input type="text" id="city" name="city" placeholder="City*"><br>
                        <input type="text" id="zipcode" name="zipcode" placeholder="Zipcode*"><br>
                        <input type="text" id="phone" name="phone" placeholder="Phone"><br><br>

                        <label for="fname">Account details</label><br>
                        <input type="text" id="mailadress" name="mailadress" placeholder="Email*"><br>
                        <input type="password" id="password" name="password" placeholder="Password*"><br>
                        <input type="password" id="verifypassword" name="verifypassword" placeholder="Verify your password*"><br>
                        * Mandatory input.
                        <br><br>
                        <input type="submit" value="Create"><br>
                        By creating an account, you accept our <a href="#">Terms & Conditions</a>.
                    </form>
                </div>
            </div>
        );
    }
}
