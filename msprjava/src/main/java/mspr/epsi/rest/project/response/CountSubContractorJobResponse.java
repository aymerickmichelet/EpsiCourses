package mspr.epsi.rest.project.response;

import mspr.epsi.rest.project.entity.CountSubContractorJob;
import mspr.epsi.rest.utils.Response;

import java.util.List;

public class CountSubContractorJobResponse extends Response {

    List<CountSubContractorJob> data;

    public CountSubContractorJobResponse(int status, String msg,  List<CountSubContractorJob>  data) {
        super(status, msg);
        this.data = data;
    }

    public List<CountSubContractorJob> getData() {
        return data;
    }

    public void setData(List<CountSubContractorJob> data) {
        this.data = data;
    }
}
