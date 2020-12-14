import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet(name = "AjouterTerrain", urlPatterns = "/AjouterTerrain")
public class AjouterTerrain extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        String codeTerrain = request.getParameter("codeTerrain");
        String[] sportsAutorises = request.getParameterValues("sportsAutorises");

        Terrain terrainAjouter = new Terrain(codeTerrain, Structure.ADAPTATEUR);
        for (String codeSport : sportsAutorises) {
            Sport sport = new Sport();
            sport.setIdentifiant(Integer.parseInt(codeSport));
            terrainAjouter.getSportsAutorises().add(sport);
        }
        //ecriture de la reponse
        request.setAttribute("AjouterTerrain", terrainAjouter);

        RequestDispatcher rd = request.getRequestDispatcher("ConfirmationAjoutTerrain");
        rd.forward(request, response);
    }
}
