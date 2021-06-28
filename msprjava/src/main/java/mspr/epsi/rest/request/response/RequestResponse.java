package mspr.epsi.rest.request.response;

import mspr.epsi.rest.request.entity.Request;
import mspr.epsi.rest.utils.Response;

import java.util.List;

public class RequestResponse extends Response {

    private List<Request> requests;

    public RequestResponse(int status, String msg, List<Request> requests){
        super(status, msg);
        this.requests = requests;
    }

    public List<Request> getRequests() {
        return requests;
    }

    public void setRequests(List<Request> requests) {
        this.requests = requests;
    }
}
