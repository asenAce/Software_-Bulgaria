import java.io.*;
import java.util.*;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class _07_CreateZipArchive {
    public static void main(String[] args) {
        Map<String, File> files = new HashMap<String, File>() {{
            put("count-chars.txt", new File("lib/count-chars.txt"));
            put("words.txt", new File("lib/words.txt"));
            put("lines.txt", new File("lib/lines.txt"));
        }};

        ZipFiles(files, "lib/text-files.zip");
    }

    private static void ZipFiles(Map<String, File> files, String archiveName) {
        try (ZipOutputStream destination = new ZipOutputStream(new FileOutputStream(archiveName))) {

            for (Map.Entry<String, File> file : files.entrySet()) {
                try (FileInputStream source = new FileInputStream(file.getValue())) {
                    destination.putNextEntry(new ZipEntry(file.getKey()));

                    byte[] buffer = new byte[4096];
                    while (true) {
                        int readed = source.read(buffer, 0, buffer.length);
                        if (readed <= 0) break;
                        destination.write(buffer, 0, readed);
                    }
                }
            }

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}