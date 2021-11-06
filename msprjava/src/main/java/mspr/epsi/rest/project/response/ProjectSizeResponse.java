package mspr.epsi.rest.project.response;

import mspr.epsi.rest.utils.Response;

public class ProjectSizeResponse extends Response {

    private long size;

    public ProjectSizeResponse(int status, String msg, long size) {
        super(status, msg);
        this.size = size;
    }

    public long getSize() {
        return size;
    }

    public void setSize(long size) {
        this.size = size;
    }
}
