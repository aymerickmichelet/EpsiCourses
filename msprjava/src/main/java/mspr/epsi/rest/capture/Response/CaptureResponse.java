package mspr.epsi.rest.capture.Response;

import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.utils.Response;

public class CaptureResponse extends Response {

    private Capture capture;

    public CaptureResponse(int status, String msg, Capture capture) {
        super(status, msg);
        this.capture = capture;
    }

    public Capture getCapture() {
        return capture;
    }

    public void setCapture(Capture capture) {
        this.capture = capture;
    }
}
