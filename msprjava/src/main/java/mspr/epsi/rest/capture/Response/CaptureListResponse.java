package mspr.epsi.rest.capture.Response;

import mspr.epsi.rest.capture.dto.CaptureSubDto;
import mspr.epsi.rest.capture.entity.Capture;
import mspr.epsi.rest.utils.Response;

import java.util.List;

public class CaptureListResponse extends Response {

    private List<CaptureSubDto> captures;

    public CaptureListResponse(int status, String msg, List<CaptureSubDto> captures) {
        super(status, msg);
        this.captures = captures;
    }

    public List<CaptureSubDto> getCaptures() {
        return captures;
    }

    public void setCapture(List<CaptureSubDto> captures) {
        this.captures = captures;
    }
}
