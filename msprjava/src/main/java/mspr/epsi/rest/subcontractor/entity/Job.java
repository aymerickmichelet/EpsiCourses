package mspr.epsi.rest.subcontractor.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Entity
public class Job {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private long id;

    private String name;

    @OneToMany
    @JsonIgnore
    private List<Subcontractor> subcontractors;

    public Job() { super(); }

    public Job(String name) {
        this.name = name;
        this.subcontractors = new ArrayList<>();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}
