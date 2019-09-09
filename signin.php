<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Sign in</title>
        <link href="formstyle.css" rel="stylesheet" type="text/css"/>
    </head>
    <body>
        <div id="registrationform">
            <h1>S'inscrire à PBJAN</h1>
            <h4>Bienvenue</h4>
            <form method="POST" action="registration.php">
                <p class="label">
                    <label for="pseudo" class="required">pseudo</label>
                </p>
                <p class="medium">
                    <input id="pseudo" type="text"  name="pseudo" placeholder="pseudo" required="required">
                </p>
                <p class="label">
                    <label for="password" class="required">password</label>
                </p>
                <p class="medium">
                    <input id="password" type="text"  name="password" placeholder="password" required="required">
                </p>
                <p class="label">
                    <label for="confirmpassword" class="required">confirmpassword</label>
                </p>
                <p class="medium">
                    <input id="confirmpassword" type="text"  name="confirm password" placeholder="confirm password" required="required">
                </p>

                  
                  </p>
                <p class="medium">
                    <label for="email" class="required">Email</label>
                    <input id="email" type="email" name="email" placeholder="exemple@exemple.com" required="required">
                </p>
 
                <p class="label">
                    <label class="required">Classe</label>
                </p>
                <p class="checkradiobox">
                        <label for="B1">
                            <input id="B1B2" type="checkbox" name="attending[]" value="B1">
                            B1
                        </label>
                        
                        <label for="B2">
                            <input id="B2" type="checkbox" name="attending[]" value="B2">
                            B2
                        </label>
                        
                        <label for="B3">
                            <input id="B3I4" type="checkbox" name="attending[]" value="B3">
                            B3
                        </label>
                    

                        <label for="I4">
                            <input id="I4" type="checkbox" name="attending[]" value="I4">
                            I4
                        </label>

                        <label for="I5">
                            <input id="I5" type="checkbox" name="attending[]" value="I5">
                            I5
                        </label>
                </p>
                <p class="label">
                	<label class="required">Classe</label>
                </p>
                
                    
                <p id="submit">
                    <input type="submit" value="S'inscrire">
                </p>
            </form>
        </div>
    </body>
</html>
