
export class WishItem {
    constructor(public wishText : string, public isComplete : boolean = false){
        
    }

    toggleComplete(){
        this.isComplete = !this.isComplete;
    }

}
