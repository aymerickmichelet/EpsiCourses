import javax.servlet.ServletException;
import javax.servlet.ServletRequest;
import javax.servlet.ServletResponse;
import javax.servlet.annotation.WebInitParam;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Enumeration;

@WebServlet(
        name = "MaServlet",
        description = "Ma première servlet",
        urlPatterns = {
                "/MaServlet",
                "/MaServlet/*"
        },
        initParams = {
            @WebInitParam(
                    description = "Un paramètre",
                    name = "auteur",
                    value = "Aymerick"
            )
        })
public class MaServlet extends HttpServlet {
    private String auteur;

    public MaServlet() {
        super();
    }

    @Override
    public void init() throws ServletException {
        System.out.println("Appel de la méthode init de la servlet");
        auteur = getInitParameter("auteur");
    }

    @Override
    public void service(ServletRequest req, ServletResponse res) throws ServletException, IOException {
        System.out.println("Appel de la méthode service de la servlet");
        super.service(req, res);
    }

    @Override
    public void destroy() {
        System.out.println("Appel de la méthode destroy de la servlet");
        super.destroy();
    }

    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        doGet(request, response);
        System.out.println("");

    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
        response.getWriter().append("\nServeur démarrage : ").append(request.getContextPath());
        response.getWriter().append("\nPath de la servlet : ").append(request.getContextPath());
        response.getWriter().append("\nContexte de la servlet : ").append(getServletContext().toString());
        response.getWriter().append("\nNom de la servlet : ").append(getServletName());
        response.getWriter().append("\nInfos de la servlet : ").append(getServletInfo());
        response.getWriter().append("\nParamètre de la servlet : ").append(getInitParameter("auteur"));
        response.getWriter().append("\nId de session de la servlet : ").append(request.getSession().getId());
        SimpleDateFormat formatDate = new SimpleDateFormat("dd-MM-yyyy 'at' HH:mm:ss");
        Date date = new Date(request.getSession().getCreationTime());
        response.getWriter().append("\nDate de session de la servlet : ").append(formatDate.format(date));
        response.getWriter().append("\nProtocole de la servlet : ").append(request.getScheme());
        response.getWriter().append("\nNom d'hôte de la servlet : ").append(request.getServerName());
        response.getWriter().append("\nPort du serveur : ").append(String.valueOf(request.getServerPort()));
        response.getWriter().append("\nRetourne les paramètre passé : ").append(request.getQueryString());
        response.getWriter().append("\nIp de l'émetteur de la requete : ").append(request.getRemoteAddr());
        response.getWriter().append("\nNom de l'hôte de l'émetteur de la requête : ").append(request.getRemoteHost());
        response.getWriter().append("\nIp carte réseau du serveur revoyant la requête : ").append(request.getLocalAddr());
        response.getWriter().append("\nNom de l'hôte envoyant la requête : ").append(request.getLocalName());
        response.getWriter().append("\nPort de réception de la requête : ").append(String.valueOf(request.getLocalPort()));


        response.getWriter().append("\nLecture de l'en tête : ");
        response.getWriter().append("\nEncodage de la requête : ").append(request.getCharacterEncoding());
        response.getWriter().append("\nTaille en octet des informations : ").append(String.valueOf(request.getContentLength()));
        response.getWriter().append("\nType de média (MIME) : ").append(request.getContentType());
        response.getWriter().append("\nLa langue demandée : ").append(String.valueOf(request.getLocale()));
        response.getWriter().append("\nType de requête (POST ou GET) : ").append(request.getMethod());
        response.getWriter().append("\nLa langue demandée : ").append(String.valueOf(request.getHeaderNames()));
        Enumeration headersNames = request.getHeaderNames();
        while(headersNames.hasMoreElements()){
            response.getWriter().append("\nClef : " + headersNames.nextElement()
                    + " Valeur : " + request.getHeader((String) headersNames.nextElement()));
        }


    }

}
