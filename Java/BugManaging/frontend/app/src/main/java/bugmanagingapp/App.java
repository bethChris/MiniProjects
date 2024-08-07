/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package bugmanagingapp;

import java.io.IOException;
import java.io.InputStream;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.util.List;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class App implements Runnable {
    private static JFrame mainFrame;
    private static CardLayout cardLayout;
    private static JPanel mainPanel;
    private JTextArea reportsText = new JTextArea();

    public void run(){
        show();
    }

    public void show(){
        mainFrame = new JFrame("Bug Manager");
        mainFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        mainFrame.setSize(500,500);
        cardLayout = new CardLayout();
        mainPanel = new JPanel(cardLayout);


        //Home Panel
        JPanel homePanel = new JPanel();
        homePanel.setLayout(new BorderLayout());

        JButton viewAllButton = new JButton("View All");
        viewAllButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // change panel and call API worker
                cardLayout.show(mainPanel, "allReportsPanel");
                new APIWorker().execute();
            }
        });

        homePanel.add(viewAllButton, BorderLayout.SOUTH);
        

        // All Reports Panel
        JPanel allReportsPanel = new JPanel();
        allReportsPanel.setLayout(new BorderLayout());

        JButton backButton = new JButton("Go Back");
        backButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                cardLayout.show(mainPanel, "homePanel");
            }
        });


        allReportsPanel.add(backButton, BorderLayout.SOUTH);
        allReportsPanel.add(reportsText);

        // Add all panels to main panel
        mainPanel.add(homePanel, "homePanel");
        mainPanel.add(allReportsPanel, "allReportsPanel");

        mainFrame.add(mainPanel);
        mainFrame.setVisible(true);

        cardLayout.show(mainPanel, "homePanel");
    }

    
    public String listReports() {      
        HttpClient httpClient = HttpClient.newHttpClient();  
        HttpRequest request = HttpRequest.newBuilder(URI.create(Utils.USER_API)).GET().build();  
        try {  
            HttpResponse<InputStream> response = httpClient.send(request, HttpResponse.BodyHandlers.ofInputStream());  
    
            // int statusCode = response.statusCode();  
            // System.out.println("HTTP status: " + statusCode);  

            System.out.println("Reports returned in request: ");  
            
            // TODO: temporary, build a string of what the reports show. eventually stick this info in a table
            StringBuilder sb = new StringBuilder();
            for (Report element : Utils.toList(response.body())) {
                sb.append(element.ReportId()).append(" | ");
                sb.append(element.ReportDescr()).append(" | ");
                sb.append(element.ReportDate()).append("\n");
            }
            System.out.println(sb.toString());
            String reports = sb.toString();

            // System.out.println("Headers:");  
            // response.headers().map().forEach((header, value) -> System.out.println(header + " = " + String.join(", ", value))); 

            return reports;
        }  
        catch (IOException | InterruptedException e) {  
            throw new RuntimeException(e);  
        }  
    }

    //Little worker class that will grab reports and update swing component when completed
    private class APIWorker extends SwingWorker<String, Void>{
        @Override
        public String doInBackground() {
            System.out.println("loading...");
            return listReports();
        }

            @Override
        protected void done() {
            try {
                reportsText.setText(get());
            } catch (Exception ignore) {
            }
        }
    }
    public static void main(String[] args) {
        SwingUtilities.invokeLater(new App());
        
    }
}
