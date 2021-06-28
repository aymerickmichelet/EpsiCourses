package mspr.epsi.rest.project.entity;

public class CountSubContractorJob {

    private Long count;
    private String jobName;
    private Long jobId;

    public CountSubContractorJob(Long count, String jobName, Long jobId) {
        this.count = count;
        this.jobName = jobName;
        this.jobId = jobId;
    }

    public Long getCount() {
        return count;
    }

    public void setCount(Long count) {
        this.count = count;
    }

    public String getJobName() {
        return jobName;
    }

    public void setJobName(String jobName) {
        this.jobName = jobName;
    }

    public Long getJobId() {
        return jobId;
    }

    public void setJobId(Long jobId) {
        this.jobId = jobId;
    }
}

