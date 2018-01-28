from flask import Flask, request
from flask_restful import Resource, Api
from passwords import pw

app = Flask(__name__)
api = Api(app)

class SetPassword(Resource):
    def get(self):
        args = request.args
        passMaker = pw()
        site = args['website']
        color = args['color']
        base = args['base']
        
        password = passMaker.formPass(color,base)
        passMaker.savePass(site,password)
        return {'website': args['website'], 'password': password}

class GetPassword(Resource):
    def get(self):
        args = request.args
        passMaker = pw()
        site = args['website']
        return passMaker.fetchPass(site)


api.add_resource(SetPassword, '/set-password')
api.add_resource(GetPassword, '/get-password')

if __name__ == '__main__':
    app.run(debug=True)