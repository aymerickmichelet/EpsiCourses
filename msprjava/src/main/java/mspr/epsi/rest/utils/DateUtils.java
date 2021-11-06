package mspr.epsi.rest.utils;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.Duration;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class DateUtils {

    public static Date getDate(String dateString)  {
        try {
            String pattern = "yyyy-MM-dd";
            SimpleDateFormat simpleDateFormat = new SimpleDateFormat(pattern);

            Date date = simpleDateFormat.parse(dateString);
            return date;
        }
        catch(ParseException e) {
            return new Date(); // pk ne pas return null ?
        }
    }

    public static boolean compareDatePassword(Date date) {
        Date dateNow = new Date();
        SimpleDateFormat df = new SimpleDateFormat("dd");

        long diff = dateNow.getTime() - date.getTime();

        long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
        return days > 30;
    }

    public static boolean blockPassword(Date date) {
        Date dateNow = new Date();
        SimpleDateFormat df = new SimpleDateFormat("dd");

        long diff = dateNow.getTime() - date.getTime();

        long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
        return days > 37;
    }

    public static boolean compareYears(int year, Date date) {
        SimpleDateFormat df = new SimpleDateFormat("yyyy");
        int yearDate = Integer.parseInt(df.format(date));

        return yearDate == year;
    }

    public static boolean compareMonth(int month, Date date) {
        SimpleDateFormat df = new SimpleDateFormat("MM");
        int monthDate = Integer.parseInt(df.format(date));

        return monthDate == month;
    }

    public static boolean compareDay(int day, Date date){
        SimpleDateFormat df = new SimpleDateFormat("dd");
        int dayDate = Integer.parseInt(df.format(date));

        return dayDate == day;
    }

    public static boolean isWithinRange(Date start, Date end, Date date) {
        return !(date.before(start) || date.after(end));
    }

    public static boolean compareDate(int year, int month, int day, Date date){
        return DateUtils.compareYears(year, date) &&
                DateUtils.compareMonth(month, date) &&
                DateUtils.compareDay(day, date);
    }
}
