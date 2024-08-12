from flask import Flask, request, render_template, url_for, redirect

cycle_order = ["home", "retro", "minimalist", "vibrant", "edgy"]
cur_cycle = 0

app = Flask(__name__)

def get_game_data():
    #place to put the API call to that free game data api we wanted to find
    print("yo")

@app.route("/")
def home():
    return render_template('index.html', style="generic-styles.css")

@app.route("/retro")
def retro():
    return render_template('index.html', style="retro-styles.css")

@app.route("/minimalist")
def minimalist():
    return render_template('index.html', style="minimalist-styles.css")

@app.route("/vibrant")
def vibrant():
    return render_template('index.html', style="vibrant-styles.css")

@app.route("/edgy")
def edgy():
    return render_template('index.html', style="edgy-styles.css")

@app.route("/cycle")
def cycle():
    global cur_cycle 
    cur_cycle = (cur_cycle + 1) % len(cycle_order)
    return redirect(url_for(cycle_order[cur_cycle]))