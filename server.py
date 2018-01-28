# server.py

#   Copyright 2018 Tate M. Walker, Kayla M. Barden

#   Licensed under the Apache License, Version 2.0 (the "License");
#   you may not use this file except in compliance with the License.
#   You may obtain a copy of the License at

#       http://www.apache.org/licenses/LICENSE-2.0

#   Unless required by applicable law or agreed to in writing, software
#   distributed under the License is distributed on an "AS IS" BASIS,
#   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
#   See the License for the specific language governing permissions and
#   limitations under the License.

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
        return {'password': passMaker.fetchPass(site)}


api.add_resource(SetPassword, '/set-password')
api.add_resource(GetPassword, '/get-password')

if __name__ == '__main__':
    app.run(debug=True,host='0.0.0.0') #run on local ip. C# needs to connect to new ip everytime