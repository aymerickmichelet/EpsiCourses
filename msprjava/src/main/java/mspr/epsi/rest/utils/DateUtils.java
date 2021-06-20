package mspr.epsi.rest.utils;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class DateUtils {

    public static Date getDate(String dateString)  {
        try {
            String pattern = "yyyy-MM-dd";
            SimpleDateFormat simpleDateFormat = new SimpleDateFormat(pattern);

            Date date = simpleDateFormat.parse(dateString);
            return date;
        }
        catch(ParseException e) {
            return new Date();
        }
    }

    public static boolean compareYears(int year, Date date) {
        SimpleDateFormat df = new SimpleDateFormat("yyyy");
        int yearDate = Integer.parseInt(df.format(date));

        System.out.println("yearDate : " + yearDate);

        return yearDate == year;

    }

    public static boolean compareMonth(int month, Date date) {
        SimpleDateFormat df = new SimpleDateFormat("MM");
        int monthDate = Integer.parseInt(df.format(date));

        System.out.println("monthDate :" + monthDate);

        return monthDate == month;

    }

    public static boolean isWithinRange(Date start, Date end, Date date) {
        return !(date.before(start) || date.after(end));
    }
}
