package bugmanagingapp;

import java.io.IOException;
import java.io.InputStream;
import java.io.UncheckedIOException;
import java.util.List;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;

public class Utils {
    private Utils() {}

    public static final String USER_API = "http://localhost:5000/reports";
    public static final ObjectMapper OBJECT_MAPPER = new ObjectMapper();

    // Report test = new Report(null, null, null, "Bobberann", null, null);
    public static List<Report> toList(InputStream inputStream) {
        try {
            return OBJECT_MAPPER.readValue(inputStream, new TypeReference<List<Report>>() {});
        } catch (IOException exc) {
            throw new UncheckedIOException(exc);
        }
    }

    public static Report toObject(InputStream inputStream) {
        try {
            return OBJECT_MAPPER.readValue(inputStream, Report.class);
        } catch (IOException exc) {
            throw new UncheckedIOException(exc);
        }
    }

    public static String toJson(Report report) {
        try {
            return OBJECT_MAPPER.writeValueAsString(report);
        } catch (JsonProcessingException exc) {
            throw new UncheckedIOException(exc);
        }
    }
}
