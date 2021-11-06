package mspr.epsi.rest.request;

import mspr.epsi.rest.project.entity.Project;
import mspr.epsi.rest.project.entity.UserProject;
import mspr.epsi.rest.request.entity.Request;
import mspr.epsi.rest.request.repository.RequestRepository;
import mspr.epsi.rest.subcontractor.entity.Subcontractor;
import mspr.epsi.rest.user.entity.UserEntity;
import mspr.epsi.rest.utils.DateUtils;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class RequestService {

    private RequestRepository requestRepository;

    public RequestService(RequestRepository requestRepository){
        this.requestRepository = requestRepository;

        /*this.requestRepository.save(
                new Request(
                        DateUtils.getDate("2021-01-01"),
                        new Project(
                            "Project 1",
                                DateUtils.getDate("2020-09-05"),
                                DateUtils.getDate("2021-04-18"),
                                "42 rue des potiers Elancourt 78990 rpz",
                                new ArrayList<Subcontractor>()
                        ),
                        new UserEntity(
                                "userId1",
                                "DOL",
                                "Nicolas",
                                "MAXIBG",
                                "jesuisunmaxibg",
                                42,
                                DateUtils.getDate("2021-01-16"),
                                new ArrayList<UserProject>(),
                                new ArrayList<Request>()
                        )
                )
        );

        this.requestRepository.save(
                new Request(
                        DateUtils.getDate("2021-02-02"),
                        new Project(
                                "Project 2",
                                DateUtils.getDate("2020-12-13"),
                                DateUtils.getDate("2021-02-20"),
                                "42 rue des potiers Elancourt 78990 rpz",
                                new ArrayList<Subcontractor>()
                        ),
                        new UserEntity(
                                "userId1",
                                "DOL",
                                "Nicolas",
                                "MAXIBG",
                                "jesuisunmaxibg",
                                42,
                                DateUtils.getDate("2021-01-16"),
                                new ArrayList<UserProject>(),
                                new ArrayList<Request>()
                        )
                )
        ); */
    }

    public List<Request> findAll(){
        List<Request> requests = new ArrayList<Request>();
        this.requestRepository.findAll().forEach(requests::add);
        return requests;
    }

//    public List<Request> findRequestsAfterDate(Date dateLimit){
//        List<Request> requests = new ArrayList<Request>();
//        for (Request request : this.requestRepository.findAll()){
//               if (request.getDate().compareTo(dateLimit) <= 0){
//                   requests.add(request);
//               }
//        }
//        return requests;
//    }

    public List<Request> findRequestsAfterDate(Date dateLimit){
        return this.requestRepository.getRequestsAfterDate(dateLimit);
    }
}
