package bugmanagingapp;


import java.sql.Date;

public record Report(
    Integer ReportId,	
    Integer BugId,
    Integer UserId,
    String ReportDescr,
    Date ReportDate,
    Date ResolvedDate
) {
    
}
