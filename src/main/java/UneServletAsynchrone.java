import javax.servlet.AsyncContext;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "UneServletAsynchrone",
        urlPatterns = "/UneServletAsynchrone",
        asyncSupported = true)
public class UneServletAsynchrone extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        System.out.println("Le traitement qui suit va se faire de façon asynchrone");
        // obtention d'un contexte asynchrone afin de faire des traitements en tache de fond
        final AsyncContext contexteAsynchrone = request.startAsync();
        contexteAsynchrone.start(new Runnable() {
            @Override
            public void run() {
                // cette méthode doit contenir le traitement à réaliser de manière asynchrone
                HttpServletRequest request = (HttpServletRequest) contexteAsynchrone.getRequest();
                HttpServletResponse response = (HttpServletResponse) contexteAsynchrone.getResponse();
                System.out.println("Début de la réalisation du traitement asynchrone qui durera un certain temps");
                try {
                    Thread.sleep(3000);
                    response.setStatus(HttpServletResponse.SC_OK);
                    response.setContentType("text/plain");
                    PrintWriter pw = response.getWriter();
                    pw.println("Traitement asynchrone");
                    pw.close();
                } catch (InterruptedException | IOException e) {
                    e.printStackTrace();
                }
                System.out.println("Fin du traitement asynchrone");
                //notification de la fin du traitement en appelant la méthode complète.
                // La réponse est envoyé au client.
                contexteAsynchrone.complete();
            }
        });
        System.out.println("Fin de traitement de la requête, un traitement asynchrone a été lancé");
        System.out.println("Le Tread est déjà prêt à traiter une autre requête client");
    }
}
