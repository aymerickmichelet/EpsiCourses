package mspr.epsi.rest.subcontractor.entity;

import com.fasterxml.jackson.annotation.JsonIgnore;

import javax.persistence.*;
import java.util.List;

@Entity
public class Job {

    @Id
    @GeneratedValue(strategy =  GenerationType.AUTO)
    private int id;

    private String name;

    @OneToMany
    @JsonIgnore
    private List<Subcontractor> subcontractors;

    public Job() { super(); }

}
