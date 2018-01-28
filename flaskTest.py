from flask import Flask, request
from flask_restful import Resource, Api
from passwords import pw

app = Flask(__name__)
api = Api(app)

class HelloWorld(Resource):
    def get(self):
        return {'hello': 'world'}

class SetWebsite(Resource):
    def get(self):
        args = request.args
        passMaker = pw()
        site = args['website']
        color = args['color']
        base = args['base']
        
        print(site)
        print(color)
        print(base)


        password = passMaker.formPass(color,base)
        passMaker.savePass(site,password)
        return {'website': args['website'], 'password': password}

api.add_resource(HelloWorld, '/')
api.add_resource(SetWebsite, '/set-website')

if __name__ == '__main__':
    app.run(debug=True)