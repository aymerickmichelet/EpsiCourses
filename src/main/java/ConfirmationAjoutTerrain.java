import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.io.PrintWriter;

@WebServlet(name = "ConfirmationAjoutTerrain", urlPatterns = "/ConfirmationAjoutTerrain")
public class ConfirmationAjoutTerrain extends HttpServlet {
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        //récupération terrain
        Terrain terrainAjoute = (Terrain) request.getAttribute("AjouterTerrain");

        //entête
        response.setStatus(HttpServletResponse.SC_OK);
        response.setContentType("text/html");
        response.setCharacterEncoding("UTF-8");

        //corps
        RequestDispatcher rd;
        PrintWriter pw = response.getWriter();

        //doctype
        rd = request.getRequestDispatcher("/WEB-INF/fragments/header.html");
        rd.include(request, response);
        pw.println("<title>Confirmation ajout d'un terrain</title>");

        //body
        rd = request.getRequestDispatcher("/WEB-INF/fragments/body.html");
        rd.include(request, response);
        pw.println("confirmation ajout d'un terrain " + terrainAjoute.getCodeTerrain());

        //footer
        rd = request.getRequestDispatcher("/WEB-INF/fragments/footer.html");
        rd.include(request, response);

        pw.flush();
        pw.close();
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doPost(request, response);
    }
}
