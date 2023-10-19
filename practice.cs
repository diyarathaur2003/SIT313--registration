* {
    font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    margin: 0;
    padding: 0;
    box-sizing: border-box;

}

.body1 {

    display: flex;
    /* justify-content: center; */
    flex-direction: column;
    justify-content: center;
    align-items: center;
}

.login {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    border: 2px solid black;
    width: 30%;
    margin-top: 100px;
    padding: 20px;
    background-color: white;
    box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
    
}

h1 {
    text-align: center;
    color: rgb(109, 109, 222);
    margin-bottom: 20px;
}

.login form {
    display: flex;
    flex-direction: column;
    width: 100%;
}

.login label {
    margin-bottom: 10px;
}

.login input {
    padding: 8px;
    margin-bottom: 15px;
    border: 1px solid #ccc;
    border-radius: 4px;
    font-size: 16px;
}

.login button {
    background-color: #007bff;
    color: white;
    padding: 10px 15px;
    border: none;
    border-radius: 4px;
    font-size: 16px;
    cursor: pointer;
}

.login button:disabled {
    background-color: #ccc;
    cursor: not-allowed;
}

.alert {
    background-color: #f44336;
    color: white;
    padding: 10px;
    border-radius: 4px;
    margin-bottom: 15px;
}

.account {
    margin-top: 10px;
    text-align: center;
}

.account a {
    color: #007bff;
    text-decoration: none;
    font-weight: bold;
}

.diya {
    margin-top: 10px;
    display: flex;
    width: 80%;
    padding-top: 90px;
}

.button:hover {
    background-color: #0056b3;
    color: #fff;
    opacity: 0.6s;
}
@media only screen and (max-width: 481px)
{
    .login{
       width: 30%;
    }
    
}
@media only screen and (max-width: 392px)
{
    .login{
       width: 60%;
    }
    
}
