import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import axios from "axios";


        var array =[{id: 1, name:'Chris', fem: false}, {id: 2, name:'Christa', fem: true},
                    {id: 3, name:'asd0s', fem: false},{id: 4, name:'Cadssdis', fem: true}];

         var  Red = function(props)
            {
               return (
                   <h1 className="red">Red, {props.name} </h1> 
               );
            }


        class Forms extends React.Component {
            constructor(props) {
                super(props);
                this.state = {
                    value: ''
                };
                this.handleChange = this.handleChange.bind(this);
                this.handleSubmit = this.handleSubmit.bind(this);
            }

            handleChange(event) {
                this.setState({
                    value: event.target.value
                });
            }

            handleSubmit(event) {
                alert('sumbited text: ' + this.state.value);
                event.preventDefault();
            }

            render() {
                return (
                    <form onSubmit={this.handleSubmit}>
                        <label>
                        Name:
                         <input placeholder="name" type="text" id="testowy" value={this.state.value} onChange={this.handleChange}/>

                         </label>
                         <input type="submit" value="Submit" />
                         <h2>{this.state.value}</h2>
                    </form>
                );
            }
        }

         class Orange extends React.Component {
        handleButton() {
            alert("warning!");
        }

            render()
            {
                var orangeStyle = {
                    backgroundColor: this.props.color
                }
                return (
                    <div>
                     <h1 style = {orangeStyle}>orange</h1>
                     <button onClick = {this.handleButton}>edit</button> 
                     </div>
                );

            }
        }

         class ColorText extends React.Component {
            render()
            {
                var orangeStyle = {
                    backgroundColor: this.props.color
                }
                return (
                     <h1 style  ={orangeStyle}>{this.props.color}</h1>
                );

            }
        }

        class Api extends React.Component {
            constructor(props) {
                super(props);
                this.state = {
                    items: []
                };
            }

            componentDidMount() {
                console.log('xd');
                axios.get('http://localhost:5000/Card')
                .then(res => {
                    const items = res.data;
                    this.setState({ items: items });
                }).catch(err => { console.log(err)})
            }

            render()
            {
                let items = this.state.items;
                console.log({items});
                return(
                    <div>
                        {items.map(function(item) {
                        return <h4 key={item.ID}>{item.title}</h4>
                                    
                        })}
                    </div>
                );
            }
        }

        var HellTest = function() {
        return(
         <h1>Hello World</h1>
           );
        }

        function Family(props)
        {
            var arr = props.arr;

            var arrList = arr.filter(function (per) {
                return per.fem;
            }).map(function(per)
            {
                return <div key={per.id}>{per.name}</div>
            });

            return(
                <div>{arrList}</div>
            );
        }

        function Family2(props)
        {

            return(
                <div>
                {
                    props.arr.filter(function (per) {
                         return per.fem === false;
                    }).map(function(per) {
                return <div key={per.id}>{per.name}</div>
                     })
                }
               </div>
            )
          
        }
         

        
         ReactDOM.render(
             <div>
                <HellTest/>
                <Red name ="Elo"/>
                <Orange color="tomato"/>
                <ColorText color="red"/>
                <ColorText color='indigo'/>
                <Family2 arr = {array}/>
                <Forms/>
                <Api/>
            </div>,
         document.getElementById("root") );


